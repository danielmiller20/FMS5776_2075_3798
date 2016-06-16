﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FMS_adapter;


namespace FMS_GUI
{
    public class DMS
    {
        List<FCB> fcbList;
        uint fcbListSize;
        Disk disk;
        FCB fcb;

        public DMS(uint size = 5)
        {
            fcbList = new List<FCB>();
            fcbListSize = size;
            for (int i = 0; i < fcbListSize; i++)
            {
                disk = new Disk();
                fcbList.Add(disk.openFile("", MODE.WR));
            }
        }
        ~DMS()
        {
            fcbList.Clear();
            fcbList = null;
        }
        public FCB openfile(string fn, MODE mode)
        {
            try
            {
                if (disk == null) throw new Exception("no file");
                fcb = disk.openFile(fn, mode);
                return fcb;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //public FCB lookForFcb(string fn)
        //{
        //    try
        //    {
        //        if (disk == null) throw new Exception("no file");
        //        foreach (FCB file in fcbList)
        //        {
        //            if (file.Loaded == false)
        //            {
        //                //foreach (FCB FileInDisk in disk.)
        //                {

        //                }
        //                return file;
        //            }
        //        }
        //        //fcb = disk.openFile(fn, mode);
        //        //return ;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}


    }
}
