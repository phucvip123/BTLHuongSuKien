﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAn.DTO
{
    internal class Table
    {
        private int id;
        private string name;
        private string status;
        public Table(int id,string name, string status)
        {
            this.id = id;
            this.name = name;
            this.status = status;
        }
        public Table(DataRow row)
        {
            this.id = (int)row["id"];
            this.name = row["name"].ToString();
            this.status = row["status"].ToString();
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Status { get => status; set => status = value; }
    }
}
