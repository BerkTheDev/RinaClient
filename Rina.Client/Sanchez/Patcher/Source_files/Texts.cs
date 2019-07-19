using System;
using System.Collections.Generic;

namespace Sanchez.Patcher.Source_files
{
	// Token: 0x02000023 RID: 35
	internal class Texts
	{
		// Token: 0x060000D7 RID: 215 RVA: 0x00009808 File Offset: 0x00009808
		public static string GetText(string Key, params object[] Arguments)
		{
			foreach (KeyValuePair<string, string> keyValuePair in Texts.Text)
			{
				if (keyValuePair.Key == Key)
				{
					return string.Format(keyValuePair.Value, Arguments);
				}
			}
			return null;
		}

		// Token: 0x040000A8 RID: 168
		private static Dictionary<string, string> Text = new Dictionary<string, string>
		{
			{
				"UNKNOWNERROR",
				"Bilinmeyen, ancak kritik bir hata oldu .. Sorunu çözmeye yardımcı olabilecek hata mesajı:\n {0}"
			},
			{
				"MISSINGBINARY",
				"{0} eksik olduğundan oyun başlatılamıyor."
			},
			{
				"CANNOTSTART",
				"Oyuna başlayamazsınız, muhtemelen antivirüsünüzü lütfen kapatın."
			},
			{
				"NONETWORK",
				"Sunucuya bağlanılamıyor, lütfen ağ ayarlarınızı kontrol edin ve tekrar deneyin."
			},
			{
				"CONNECTING",
				"Sunucuya bağlanılıyor..."
			},
			{
				"LISTDOWNLOAD",
				"Günceleme listesi indiriliyor..."
			},
			{
				"CHECKFILE",
				"{0} kontrol ediliyor..."
			},
			{
				"DOWNLOADFILE",
				"{0} indiriliyor... {1}/ {2}"
			},
			{
				"COMPLETEPROGRESS",
				"Toplam İlerleme: {0}%"
			},
			{
				"CURRENTPROGRESS",
				"Dosya İlerlemesi: {0}%  |  {1} kb/s"
			},
			{
				"CHECKCOMPLETE",
				"Her dosya düzgün kontrol edildi."
			},
			{
				"DOWNLOADCOMPLETE",
				"Gerekli tüm dosyalar düzgün şekilde indirildi."
			},
			{
				"DOWNLOADSPEED",
				"{0} kb/s"
			}
		};
	}
}
