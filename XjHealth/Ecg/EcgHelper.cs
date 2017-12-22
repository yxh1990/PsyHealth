using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using libNeuroSkyECG;
using System.Threading;
using System.Windows.Forms;
using System.Collections;
using libStreamSDK;

namespace XjHealth.Ecg
{
    public interface IDriverConnectListener
    {
        void AfterDriverConnectedSuc();

        void AfterDriverConnectedFailed();

        void AfterDriverDisconnected();
    }
    public class EcgHelper
    {
        // 神念采集器
        private NativeThinkgear thinkgear = new NativeThinkgear();

        // 是否断开标志位
        public bool isOff = true;


        private static EcgHelper helper = null;

        private List<IDriverConnectListener> arr = new List<IDriverConnectListener>();

        public int connectionId = -1;

        // 私有函数
        private EcgHelper()
        {
        }

        public void AddDriverConnectListener(IDriverConnectListener dc)
        {
            if (dc != null)
                this.arr.Add(dc);
        }

        // 单例模式
        public static EcgHelper getInstance()
        {
            if (helper == null)
            {
                helper = new EcgHelper();
            }
            return helper;
        }

        public int ConnectDriver(string com)
        {
            // 创建连接
            connectionId = NativeThinkgear.TG_GetNewConnectionId();

            Console.WriteLine("Connection ID: " + connectionId);
            if (connectionId < 0)
            {
                // 创建连接失败
                Console.WriteLine("ERROR: TG_GetNewConnectionId() returned: " + connectionId);
                foreach (IDriverConnectListener dc in arr)
                {
                    dc.AfterDriverConnectedFailed();
                }
                return -1;
            }

            int errCode = 0;
            /* 设置流 */
            errCode = NativeThinkgear.TG_SetStreamLog(connectionId, "streamLog.txt");

            Console.WriteLine("errCode for TG_SetStreamLog : " + errCode);
            if (errCode < 0)
            {
                // 设置流失败
                Console.WriteLine("ERROR: TG_SetStreamLog() returned: " + errCode);
                foreach (IDriverConnectListener dc in arr)
                {
                    dc.AfterDriverConnectedFailed();
                }
                return -2;
            }
            errCode = NativeThinkgear.TG_SetDataLog(connectionId, "./tmp/dataLog.log");
            if (errCode < 0)
            {
                // 设置数据流失败
                Console.WriteLine("ERROR: TG_SetDataLog() returned: " + errCode);
                foreach (IDriverConnectListener dc in arr)
                {
                    dc.AfterDriverConnectedFailed();
                }
                return -3;
            }

            string comPortName = "\\\\.\\COM";
            comPortName += com;

            errCode = NativeThinkgear.TG_Connect(connectionId,
                          comPortName,
                          NativeThinkgear.Baudrate.TG_BAUD_57600,
                          NativeThinkgear.SerialDataFormat.TG_STREAM_PACKETS);
            if (errCode < 0)
            {
                // 连接设备失败
                Console.WriteLine("ERROR: TG_Connect() returned: " + errCode);
                foreach (IDriverConnectListener dc in arr)
                {
                    dc.AfterDriverConnectedFailed();
                }
                return -4;
            }
            else
            {
                Console.WriteLine("Connect successful。");
            }
            isOff = false;
            foreach (IDriverConnectListener dc in arr)
            {
                dc.AfterDriverConnectedSuc();
            }
            return connectionId;
        }

        public void DisconnectDriver(int connectionId)
        {
            NativeThinkgear.TG_SetDataLog(connectionId, "./tmp/tmp.log");

            // 主进程暂停1秒
            Thread.Sleep(2000);

            NativeThinkgear.TG_Disconnect(connectionId);

            /* Clean up */
            NativeThinkgear.TG_FreeConnection(connectionId);

            isOff = true;

            foreach (IDriverConnectListener dc in arr)
            {
                dc.AfterDriverDisconnected();
            }
        }
    }
}
