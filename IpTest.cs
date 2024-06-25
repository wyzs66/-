using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEditor.MemoryProfiler;
using UnityEngine;

public static class IpTest
{
    /// <summary>
    /// �Ƿ��� Ping ָͨ��������
    /// </summary>
    /// <param name="ip">ip ��ַ��������������</param>
    /// <returns>true ͨ��false ��ͨ</returns>
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
            int timeout = 800; // Timeout ʱ�䣬��λ������
            System.Net.NetworkInformation.PingReply reply = p.Send(ip, timeout, buffer, options);
            if (reply.Status == System.Net.NetworkInformation.IPStatus.Success)
                w_blnReturn = true;
            else
                w_blnReturn = false;

        }
        catch (Exception ex)
        {
            //�쳣��־
            Debug.Log(ex.Message);
            w_blnReturn = false;
        }
        return w_blnReturn;
    }
}
