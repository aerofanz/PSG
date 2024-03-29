﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind.Helper
{
    public class MsgHelper
    {
        /// <summary>
        /// Method untuk menampilkan pesan konfirmasi "Yes" dan "No"
        /// </summary>
        /// <param name="prompt">Informasi yang ingin ditampilkan</param>
        /// <returns></returns>
        public static bool MsgKonfirmasi(string prompt)
        {
            return (MessageBox.Show(prompt, "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes);
        }

        /// <summary>
        /// Method untuk menampilkan konfirmasi penyimpanan data
        /// </summary>
        /// <returns></returns>
        public static bool MsgSave()
        {
            return MsgKonfirmasi("Apakah Anda yakin data ini ingin disimpan ???");
        }

        /// <summary>
        /// Method untuk menampilkan peringatan
        /// </summary>
        /// <param name="prompt">Informasi yang ingin ditampilkan</param>
        public static void MsgWarning(string prompt)
        {
            MessageBox.Show(prompt, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        /// <summary>
        /// Method untuk menampilkan peringatan terjadinya duplikasi data pada saat penyimpanan
        /// </summary>
        /// <param name="prompt">Informasi yang ingin ditampilkan</param>
        public static void MsgDuplicate(string prompt)
        {
            var pesan = "Maaf, Data yang Anda masukkan gagal disimpan !\nCek apakah {0} sudah pernah digunakan.";
            MsgWarning(string.Format(pesan, prompt));
        }

        /// <summary>
        /// Method untuk menampilkan peringatan error
        /// </summary>
        /// <param name="prompt"></param>
        public static void MsgError(string prompt)
        {
            MessageBox.Show(prompt, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Method untuk menampilkan peringatan data belum dipilih
        /// </summary>
        /// <param name="prompt">Informasi yang ingin ditampilkan</param>
        public static void MsgNotSelected(string prompt)
        {
            MsgWarning("Maaf '" + prompt + "' belum dipilih !!!");
        }

        /// <summary>
        /// Method untuk menampilkan informasi
        /// </summary>
        /// <param name="prompt">Informasi yang ingin ditampilkan</param>
        public static void MsgInfo(string prompt)
        {
            MessageBox.Show(prompt, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Method untuk menampilkan konfirmasi penghapusan data
        /// </summary>
        /// <returns></returns>
        public static bool MsgDelete()
        {
            return (MsgKonfirmasi("Apakah data ini ingin dihapus ?"));
        }

        /// <summary>
        /// Method untuk menampilkan peringatan gagal pada saat menghapus data
        /// </summary>
        public static void MsgDeleteError()
        {
            MsgWarning("Maaf data gagal dihapus !\nData ini sudah digunakan untuk proses yang lain.");
        }

        /// <summary>
        /// Method untuk menampilkan peringatan gagal pada saat mengupdate data
        /// </summary>
        public static void MsgUpdateError()
        {
            MsgWarning("Maaf, Data yang Anda masukkan gagal disimpan !\nSilahkan dicoba lagi.");
        }

        /// <summary>
        /// Method untuk menampilkan peringatan ada inputan yang masih kosong
        /// </summary>
        /// <param name="prompt"></param>
        public static void MsgRequire(string prompt)
        {
            MsgWarning("Maaf, informasi '" + prompt + "' harus diisi !");
        }

        /// <summary>
        /// Method untuk menampilkan peringatan data yang dicari tidak ditemukan
        /// </summary>
        public static void MsgNotFound()
        {
            MsgWarning("Maaf data yang Anda cari tidak ditemukan");
        }

        /// <summary>
        /// Method untuk menampilkan peringatan range tanggal tidak valid
        /// </summary>
        public static void MsgNotValidRangeTanggal()
        {
            MsgWarning("Maaf range tanggal salah !!!");
        }
    }
}
