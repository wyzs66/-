using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEditor.MemoryProfiler;
using UnityEngine;

public static class IpTest
{
    /// <summary>
    /// 是否能 Ping 通指定的主机
    /// </summary>
    /// <param name="ip">ip 地址或主机名或域名</param>
    /// <returns>true 通，false 不通</returns>
    public static bool Ping(string ip)
    {
        bool w_blnReturn = false;
        try
        {

            System.Net.NetworkInformation.Ping p = new System.Net.NetworkInformation.Ping();
            System.Net.NetworkInformation.PingOptions options = new System.Net.NetworkInformation.PingOptions();
            options.DontFragment = true;
            string data = "Test Data!";
            byte[] buffer = Encoding.ASCII.GetBytes(data);
            int timeout = 800; // Timeout 时间，单位：毫秒
            System.Net.NetworkInformation.PingReply reply = p.Send(ip, timeout, buffer, options);
            if (reply.Status == System.Net.NetworkInformation.IPStatus.Success)
                w_blnReturn = true;
            else
                w_blnReturn = false;

        }
        catch (Exception ex)
        {
            //异常日志
            Debug.Log(ex.Message);
            w_blnReturn = false;
        }
        return w_blnReturn;
    }
}
