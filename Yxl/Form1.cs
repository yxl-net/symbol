﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yxl
{
    public partial class Form1 : Form
    {
        DataTable dt;

        public Form1()
        {
            InitializeComponent();
            dt = new DataTable();
            dt.Columns.Add("s1");
            dt.Columns.Add("s2");
            dt.Columns.Add("s3");
            dt.Columns.Add("s4");
            dt.Columns.Add("s5");
            dt.Columns.Add("s6");
            dt.Columns.Add("s7");
            dt.Columns.Add("s8");
            dt.Columns.Add("s9");
            dt.Columns.Add("s10");
            dt.Columns.Add("s11");
            dt.Columns.Add("s12");
            dt.Columns.Add("s13");
            dt.Columns.Add("s14");
            for(int i= 0;i<3;i++)
            {
                tsdCopy.DropDownItems.Add(dgv.Columns[i].HeaderText).ImageIndex=i;
                cmfCopy.DropDownItems.Add(dgv.Columns[i].HeaderText).ImageIndex=i;
            }
            #region 编号
            dt.Rows.Add("⓪", "\\u24EA", "&#9450;", "编号", "带圈数字序号", "0", "", "", "", "", "", "", "", "");
            dt.Rows.Add("①", "\\u2460", "&#9312;", "编号", "带圈数字序号", "1", "", "", "", "", "", "", "", "");
            dt.Rows.Add("②", "\\u2461", "&#9313;", "编号", "带圈数字序号", "2", "", "", "", "", "", "", "", "");
            dt.Rows.Add("③", "\\u2462", "&#9314;", "编号", "带圈数字序号", "3", "", "", "", "", "", "", "", "");
            dt.Rows.Add("④", "\\u2463", "&#9315;", "编号", "带圈数字序号", "4", "", "", "", "", "", "", "", "");
            dt.Rows.Add("⑤", "\\u2464", "&#9316;", "编号", "带圈数字序号", "5", "", "", "", "", "", "", "", "");
            dt.Rows.Add("⑥", "\\u2465", "&#9317;", "编号", "带圈数字序号", "6", "", "", "", "", "", "", "", "");
            dt.Rows.Add("⑦", "\\u2466", "&#9318;", "编号", "带圈数字序号", "7", "", "", "", "", "", "", "", "");
            dt.Rows.Add("⑧", "\\u2467", "&#9319;", "编号", "带圈数字序号", "8", "", "", "", "", "", "", "", "");
            dt.Rows.Add("⑨", "\\u2468", "&#9320;", "编号", "带圈数字序号", "9", "", "", "", "", "", "", "", "");
            dt.Rows.Add("⑩", "\\u2469", "&#9321;", "编号", "带圈数字序号", "10", "", "", "", "", "", "", "", "");
            dt.Rows.Add("⑪", "\\u246A", "&#9322;", "编号", "带圈数字序号", "11", "", "", "", "", "", "", "", "");
            dt.Rows.Add("⑫", "\\u246B", "&#9323;", "编号", "带圈数字序号", "12", "", "", "", "", "", "", "", "");
            dt.Rows.Add("⑬", "\\u246C", "&#9324;", "编号", "带圈数字序号", "13", "", "", "", "", "", "", "", "");
            dt.Rows.Add("⑭", "\\u246D", "&#9325;", "编号", "带圈数字序号", "14", "", "", "", "", "", "", "", "");
            dt.Rows.Add("⑮", "\\u246E", "&#9326;", "编号", "带圈数字序号", "15", "", "", "", "", "", "", "", "");
            dt.Rows.Add("⑯", "\\u246F", "&#9327;", "编号", "带圈数字序号", "16", "", "", "", "", "", "", "", "");
            dt.Rows.Add("⑰", "\\u2470", "&#9328;", "编号", "带圈数字序号", "17", "", "", "", "", "", "", "", "");
            dt.Rows.Add("⑱", "\\u2471", "&#9329;", "编号", "带圈数字序号", "18", "", "", "", "", "", "", "", "");
            dt.Rows.Add("⑲", "\\u2472", "&#9330;", "编号", "带圈数字序号", "19", "", "", "", "", "", "", "", "");
            dt.Rows.Add("⑳", "\\u2473", "&#9331;", "编号", "带圈数字序号", "20", "", "", "", "", "", "", "", "");
            dt.Rows.Add("⓿", "\\u24FF", "&#9471;", "编号", "圆形实心数字序号", "0", "", "", "", "", "", "", "", "");
            dt.Rows.Add("❶", "\\u2776", "&#10102;", "编号","圆形实心数字序号", "1", "", "", "", "", "", "", "", "");
            dt.Rows.Add("❷", "\\u2777", "&#10103;", "编号","圆形实心数字序号", "2", "", "", "", "", "", "", "", "");
            dt.Rows.Add("❸", "\\u2778", "&#10104;", "编号","圆形实心数字序号", "3", "", "", "", "", "", "", "", "");
            dt.Rows.Add("❹", "\\u2779", "&#10105;", "编号","圆形实心数字序号", "4", "", "", "", "", "", "", "", "");
            dt.Rows.Add("❺", "\\u277A", "&#10106;", "编号","圆形实心数字序号", "5", "", "", "", "", "", "", "", "");
            dt.Rows.Add("❻", "\\u277B", "&#10107;", "编号","圆形实心数字序号", "6", "", "", "", "", "", "", "", "");
            dt.Rows.Add("❼", "\\u277C", "&#10108;", "编号","圆形实心数字序号", "7", "", "", "", "", "", "", "", "");
            dt.Rows.Add("❽", "\\u277D", "&#10109;", "编号","圆形实心数字序号", "8", "", "", "", "", "", "", "", "");
            dt.Rows.Add("❾", "\\u277E", "&#10110;", "编号","圆形实心数字序号", "9", "", "", "", "", "", "", "", "");
            dt.Rows.Add("❿", "\\u277F", "&#10111;", "编号","圆形实心数字序号", "10", "", "", "", "", "", "", "", "");
            dt.Rows.Add("⓫", "\\u24EB", "&#9451;", "编号", "圆形实心数字序号", "11", "", "", "", "", "", "", "", "");
            dt.Rows.Add("⓬", "\\u24EC", "&#9452;", "编号", "圆形实心数字序号", "12", "", "", "", "", "", "", "", "");
            dt.Rows.Add("⓭", "\\u24ED", "&#9453;", "编号", "圆形实心数字序号", "13", "", "", "", "", "", "", "", "");
            dt.Rows.Add("⓮", "\\u24EE", "&#9454;", "编号", "圆形实心数字序号", "14", "", "", "", "", "", "", "", "");
            dt.Rows.Add("⓯", "\\u24EF", "&#9455;", "编号", "圆形实心数字序号", "15", "", "", "", "", "", "", "", "");
            dt.Rows.Add("⓰", "\\u24F0", "&#9456;", "编号", "圆形实心数字序号", "16", "", "", "", "", "", "", "", "");
            dt.Rows.Add("⓱", "\\u24F1", "&#9457;", "编号", "圆形实心数字序号", "17", "", "", "", "", "", "", "", "");
            dt.Rows.Add("⓲", "\\u24F2", "&#9458;", "编号", "圆形实心数字序号", "18", "", "", "", "", "", "", "", "");
            dt.Rows.Add("⓳", "\\u24F3", "&#9459;", "编号", "圆形实心数字序号", "19", "", "", "", "", "", "", "", "");
            dt.Rows.Add("⓴", "\\u24F4", "&#9460;", "编号", "圆形实心数字序号", "20", "", "", "", "", "", "", "", "");
            dt.Rows.Add("⓵", "\\u24F5", "&#9461;", "编号",  "双圈数字序号", "1", "", "", "", "", "", "", "", "");
            dt.Rows.Add("⓶", "\\u24F6", "&#9462;", "编号",  "双圈数字序号", "2", "", "", "", "", "", "", "", "");
            dt.Rows.Add("⓷", "\\u24F7", "&#9463;", "编号",  "双圈数字序号", "3", "", "", "", "", "", "", "", "");
            dt.Rows.Add("⓸", "\\u24F8", "&#9464;", "编号",  "双圈数字序号", "4", "", "", "", "", "", "", "", "");
            dt.Rows.Add("⓹", "\\u24F9", "&#9465;", "编号",  "双圈数字序号", "5", "", "", "", "", "", "", "", "");
            dt.Rows.Add("⓺", "\\u24FA", "&#9466;", "编号",  "双圈数字序号", "6", "", "", "", "", "", "", "", "");
            dt.Rows.Add("⓻", "\\u24FB", "&#9467;", "编号",  "双圈数字序号", "7", "", "", "", "", "", "", "", "");
            dt.Rows.Add("⓼", "\\u24FC", "&#9468;", "编号",  "双圈数字序号", "8", "", "", "", "", "", "", "", "");
            dt.Rows.Add("⓽", "\\u24FD", "&#9469;", "编号",  "双圈数字序号", "9", "", "", "", "", "", "", "", "");
            dt.Rows.Add("⓾", "\\u24FE", "&#9470;", "编号",  "双圈数字序号", "10", "", "", "", "", "", "", "", "");
            dt.Rows.Add("㊀", "\\u3280", "&#12928;", "编号", "带圈汉字序号", "1", "", "", "", "", "", "", "", "");
            dt.Rows.Add("㊁", "\\u3281", "&#12929;", "编号", "带圈汉字序号", "2", "", "", "", "", "", "", "", "");
            dt.Rows.Add("㊂", "\\u3282", "&#12930;", "编号", "带圈汉字序号", "3", "", "", "", "", "", "", "", "");
            dt.Rows.Add("㊃", "\\u3283", "&#12931;", "编号", "带圈汉字序号", "4", "", "", "", "", "", "", "", "");
            dt.Rows.Add("㊄", "\\u3284", "&#12932;", "编号", "带圈汉字序号", "5", "", "", "", "", "", "", "", "");
            dt.Rows.Add("㊅", "\\u3285", "&#12933;", "编号", "带圈汉字序号", "6", "", "", "", "", "", "", "", "");
            dt.Rows.Add("㊆", "\\u3286", "&#12934;", "编号", "带圈汉字序号", "7", "", "", "", "", "", "", "", "");
            dt.Rows.Add("㊇", "\\u3287", "&#12935;", "编号", "带圈汉字序号", "8", "", "", "", "", "", "", "", "");
            dt.Rows.Add("㊈", "\\u3288", "&#12936;", "编号", "带圈汉字序号", "9", "", "", "", "", "", "", "", "");
            dt.Rows.Add("㊉", "\\u3289", "&#12937;", "编号", "带圈汉字序号", "10", "", "", "", "", "", "", "", "");
            dt.Rows.Add("㈠", "\\u3220", "&#12832;", "编号", "带括号汉字序号", "1", "", "", "", "", "", "", "", "");
            dt.Rows.Add("㈡", "\\u3221", "&#12833;", "编号", "带括号汉字序号", "2", "", "", "", "", "", "", "", "");
            dt.Rows.Add("㈢", "\\u3222", "&#12834;", "编号", "带括号汉字序号", "3", "", "", "", "", "", "", "", "");
            dt.Rows.Add("㈣", "\\u3223", "&#12835;", "编号", "带括号汉字序号", "4", "", "", "", "", "", "", "", "");
            dt.Rows.Add("㈤", "\\u3224", "&#12836;", "编号", "带括号汉字序号", "5", "", "", "", "", "", "", "", "");
            dt.Rows.Add("㈥", "\\u3225", "&#12837;", "编号", "带括号汉字序号", "6", "", "", "", "", "", "", "", "");
            dt.Rows.Add("㈦", "\\u3226", "&#12838;", "编号", "带括号汉字序号", "7", "", "", "", "", "", "", "", "");
            dt.Rows.Add("㈧", "\\u3227", "&#12839;", "编号", "带括号汉字序号", "8", "", "", "", "", "", "", "", "");
            dt.Rows.Add("㈨", "\\u3228", "&#12840;", "编号", "带括号汉字序号", "9", "", "", "", "", "", "", "", "");
            dt.Rows.Add("㈩", "\\u3229", "&#12841;", "编号", "带括号汉字序号", "10", "", "", "", "", "", "", "", "");
            dt.Rows.Add("⑴", "\\u2474", "&#9332;", "编号", "带括号数字序号", "1", "", "", "", "", "", "", "", "");
            dt.Rows.Add("⑵", "\\u2475", "&#9333;", "编号", "带括号数字序号", "2", "", "", "", "", "", "", "", "");
            dt.Rows.Add("⑶", "\\u2476", "&#9334;", "编号", "带括号数字序号", "3", "", "", "", "", "", "", "", "");
            dt.Rows.Add("⑷", "\\u2477", "&#9335;", "编号", "带括号数字序号", "4", "", "", "", "", "", "", "", "");
            dt.Rows.Add("⑸", "\\u2478", "&#9336;", "编号", "带括号数字序号", "5", "", "", "", "", "", "", "", "");
            dt.Rows.Add("⑹", "\\u2479", "&#9337;", "编号", "带括号数字序号", "6", "", "", "", "", "", "", "", "");
            dt.Rows.Add("⑺", "\\u247A", "&#9338;", "编号", "带括号数字序号", "7", "", "", "", "", "", "", "", "");
            dt.Rows.Add("⑻", "\\u247B", "&#9339;", "编号", "带括号数字序号", "8", "", "", "", "", "", "", "", "");
            dt.Rows.Add("⑼", "\\u247C", "&#9340;", "编号", "带括号数字序号", "9", "", "", "", "", "", "", "", "");
            dt.Rows.Add("⑽", "\\u247D", "&#9341;", "编号", "带括号数字序号", "10", "", "", "", "", "", "", "", "");
            dt.Rows.Add("⑾", "\\u247E", "&#9342;", "编号", "带括号数字序号", "11", "", "", "", "", "", "", "", "");
            dt.Rows.Add("⑿", "\\u247F", "&#9343;", "编号", "带括号数字序号", "12", "", "", "", "", "", "", "", "");
            dt.Rows.Add("⒀", "\\u2480", "&#9344;", "编号", "带括号数字序号", "13", "", "", "", "", "", "", "", "");
            dt.Rows.Add("⒁", "\\u2481", "&#9345;", "编号", "带括号数字序号", "14", "", "", "", "", "", "", "", "");
            dt.Rows.Add("⒂", "\\u2482", "&#9346;", "编号", "带括号数字序号", "15", "", "", "", "", "", "", "", "");
            dt.Rows.Add("⒃", "\\u2483", "&#9347;", "编号", "带括号数字序号", "16", "", "", "", "", "", "", "", "");
            dt.Rows.Add("⒄", "\\u2484", "&#9348;", "编号", "带括号数字序号", "17", "", "", "", "", "", "", "", "");
            dt.Rows.Add("⒅", "\\u2485", "&#9349;", "编号", "带括号数字序号", "18", "", "", "", "", "", "", "", "");
            dt.Rows.Add("⒆", "\\u2486", "&#9350;", "编号", "带括号数字序号", "19", "", "", "", "", "", "", "", "");
            dt.Rows.Add("⒇", "\\u2487", "&#9351;", "编号", "带括号数字序号", "20", "", "", "", "", "", "", "", "");
            dt.Rows.Add("⒈", "\\u2488", "&#9352;", "编号", "带点数字序号", "1", "", "", "", "", "", "", "", "");
            dt.Rows.Add("⒉", "\\u2489", "&#9353;", "编号", "带点数字序号", "2", "", "", "", "", "", "", "", "");
            dt.Rows.Add("⒊", "\\u248A", "&#9354;", "编号", "带点数字序号", "3", "", "", "", "", "", "", "", "");
            dt.Rows.Add("⒋", "\\u248B", "&#9355;", "编号", "带点数字序号", "4", "", "", "", "", "", "", "", "");
            dt.Rows.Add("⒌", "\\u248C", "&#9356;", "编号", "带点数字序号", "5", "", "", "", "", "", "", "", "");
            dt.Rows.Add("⒍", "\\u248D", "&#9357;", "编号", "带点数字序号", "6", "", "", "", "", "", "", "", "");
            dt.Rows.Add("⒎", "\\u248E", "&#9358;", "编号", "带点数字序号", "7", "", "", "", "", "", "", "", "");
            dt.Rows.Add("⒏", "\\u248F", "&#9359;", "编号", "带点数字序号", "8", "", "", "", "", "", "", "", "");
            dt.Rows.Add("⒐", "\\u2490", "&#9360;", "编号", "带点数字序号", "9", "", "", "", "", "", "", "", "");
            dt.Rows.Add("⒑", "\\u2491", "&#9361;", "编号", "带点数字序号", "10", "", "", "", "", "", "", "", "");
            dt.Rows.Add("⒒", "\\u2492", "&#9362;", "编号", "带点数字序号", "11", "", "", "", "", "", "", "", "");
            dt.Rows.Add("⒓", "\\u2493", "&#9363;", "编号", "带点数字序号", "12", "", "", "", "", "", "", "", "");
            dt.Rows.Add("⒔", "\\u2494", "&#9364;", "编号", "带点数字序号", "13", "", "", "", "", "", "", "", "");
            dt.Rows.Add("⒕", "\\u2495", "&#9365;", "编号", "带点数字序号", "14", "", "", "", "", "", "", "", "");
            dt.Rows.Add("⒖", "\\u2496", "&#9366;", "编号", "带点数字序号", "15", "", "", "", "", "", "", "", "");
            dt.Rows.Add("⒗", "\\u2497", "&#9367;", "编号", "带点数字序号", "16", "", "", "", "", "", "", "", "");
            dt.Rows.Add("⒘", "\\u2498", "&#9368;", "编号", "带点数字序号", "17", "", "", "", "", "", "", "", "");
            dt.Rows.Add("⒙", "\\u2499", "&#9369;", "编号", "带点数字序号", "18", "", "", "", "", "", "", "", "");
            dt.Rows.Add("⒚", "\\u249A", "&#9370;", "编号", "带点数字序号", "19", "", "", "", "", "", "", "", "");
            dt.Rows.Add("⒛", "\\u249B", "&#9371;", "编号", "带点数字序号", "20", "", "", "", "", "", "", "", "");
            dt.Rows.Add("Ⅰ", "\\u2160", "&#8544;", "编号", "大写罗马数字", "1", "", "", "", "", "", "", "", "");
            dt.Rows.Add("Ⅱ", "\\u2161", "&#8545;", "编号", "大写罗马数字", "2", "", "", "", "", "", "", "", "");
            dt.Rows.Add("Ⅲ", "\\u2162", "&#8546;", "编号", "大写罗马数字", "3", "", "", "", "", "", "", "", "");
            dt.Rows.Add("Ⅳ", "\\u2163", "&#8547;", "编号", "大写罗马数字", "4", "", "", "", "", "", "", "", "");
            dt.Rows.Add("Ⅴ", "\\u2164", "&#8548;", "编号", "大写罗马数字", "5", "", "", "", "", "", "", "", "");
            dt.Rows.Add("Ⅵ", "\\u2165", "&#8549;", "编号", "大写罗马数字", "6", "", "", "", "", "", "", "", "");
            dt.Rows.Add("Ⅶ", "\\u2166", "&#8550;", "编号", "大写罗马数字", "7", "", "", "", "", "", "", "", "");
            dt.Rows.Add("Ⅷ", "\\u2167", "&#8551;", "编号", "大写罗马数字", "8", "", "", "", "", "", "", "", "");
            dt.Rows.Add("Ⅸ", "\\u2168", "&#8552;", "编号", "大写罗马数字", "9", "", "", "", "", "", "", "", "");
            dt.Rows.Add("Ⅹ", "\\u2169", "&#8553;", "编号", "大写罗马数字", "10", "", "", "", "", "", "", "", "");
            dt.Rows.Add("Ⅺ", "\\u216A", "&#8554;", "编号", "大写罗马数字", "11", "", "", "", "", "", "", "", "");
            dt.Rows.Add("Ⅻ", "\\u216B", "&#8555;", "编号", "大写罗马数字", "12", "", "", "", "", "", "", "", "");
            dt.Rows.Add("ⅰ", "\\u2170", "&#8560;", "编号", "小写罗马数字", "1", "", "", "", "", "", "", "", "");
            dt.Rows.Add("ⅱ", "\\u2171", "&#8561;", "编号", "小写罗马数字", "2", "", "", "", "", "", "", "", "");
            dt.Rows.Add("ⅲ", "\\u2172", "&#8562;", "编号", "小写罗马数字", "3", "", "", "", "", "", "", "", "");
            dt.Rows.Add("ⅳ", "\\u2173", "&#8563;", "编号", "小写罗马数字", "4", "", "", "", "", "", "", "", "");
            dt.Rows.Add("ⅴ", "\\u2174", "&#8564;", "编号", "小写罗马数字", "5", "", "", "", "", "", "", "", "");
            dt.Rows.Add("ⅵ", "\\u2175", "&#8565;", "编号", "小写罗马数字", "6", "", "", "", "", "", "", "", "");
            dt.Rows.Add("ⅶ", "\\u2176", "&#8566;", "编号", "小写罗马数字", "7", "", "", "", "", "", "", "", "");
            dt.Rows.Add("ⅷ", "\\u2177", "&#8567;", "编号", "小写罗马数字", "8", "", "", "", "", "", "", "", "");
            dt.Rows.Add("ⅸ", "\\u2178", "&#8568;", "编号", "小写罗马数字", "9", "", "", "", "", "", "", "", "");
            dt.Rows.Add("ⅹ", "\\u2179", "&#8569;", "编号", "小写罗马数字", "10", "", "", "", "", "", "", "", "");
            dt.Rows.Add("Ⓐ", "\\u24B6", "&#9398;", "编号", "带圈大写字母", "a", "", "", "", "", "", "", "", "");
            dt.Rows.Add("Ⓑ", "\\u24B7", "&#9399;", "编号", "带圈大写字母", "b", "", "", "", "", "", "", "", "");
            dt.Rows.Add("Ⓒ", "\\u24B8", "&#9400;", "编号", "带圈大写字母", "c", "", "", "", "", "", "", "", "");
            dt.Rows.Add("Ⓓ", "\\u24B9", "&#9401;", "编号", "带圈大写字母", "d", "", "", "", "", "", "", "", "");
            dt.Rows.Add("Ⓔ", "\\u24BA", "&#9402;", "编号", "带圈大写字母", "e", "", "", "", "", "", "", "", "");
            dt.Rows.Add("Ⓕ", "\\u24BB", "&#9403;", "编号", "带圈大写字母", "f", "", "", "", "", "", "", "", "");
            dt.Rows.Add("Ⓖ", "\\u24BC", "&#9404;", "编号", "带圈大写字母", "g", "", "", "", "", "", "", "", "");
            dt.Rows.Add("Ⓗ", "\\u24BD", "&#9405;", "编号", "带圈大写字母", "h", "", "", "", "", "", "", "", "");
            dt.Rows.Add("Ⓘ", "\\u24BE", "&#9406;", "编号", "带圈大写字母", "i", "", "", "", "", "", "", "", "");
            dt.Rows.Add("Ⓙ", "\\u24BF", "&#9407;", "编号", "带圈大写字母", "j", "", "", "", "", "", "", "", "");
            dt.Rows.Add("Ⓚ", "\\u24C0", "&#9408;", "编号", "带圈大写字母", "k", "", "", "", "", "", "", "", "");
            dt.Rows.Add("Ⓛ", "\\u24C1", "&#9409;", "编号", "带圈大写字母", "l", "", "", "", "", "", "", "", "");
            dt.Rows.Add("Ⓜ", "\\u24C2", "&#9410;", "编号", "带圈大写字母", "m", "", "", "", "", "", "", "", "");
            dt.Rows.Add("Ⓝ", "\\u24C3", "&#9411;", "编号", "带圈大写字母", "n", "", "", "", "", "", "", "", "");
            dt.Rows.Add("Ⓞ", "\\u24C4", "&#9412;", "编号", "带圈大写字母", "o", "", "", "", "", "", "", "", "");
            dt.Rows.Add("Ⓟ", "\\u24C5", "&#9413;", "编号", "带圈大写字母", "p", "", "", "", "", "", "", "", "");
            dt.Rows.Add("Ⓠ", "\\u24C6", "&#9414;", "编号", "带圈大写字母", "q", "", "", "", "", "", "", "", "");
            dt.Rows.Add("Ⓡ", "\\u24C7", "&#9415;", "编号", "带圈大写字母", "r", "", "", "", "", "", "", "", "");
            dt.Rows.Add("Ⓢ", "\\u24C8", "&#9416;", "编号", "带圈大写字母", "s", "", "", "", "", "", "", "", "");
            dt.Rows.Add("Ⓣ", "\\u24C9", "&#9417;", "编号", "带圈大写字母", "t", "", "", "", "", "", "", "", "");
            dt.Rows.Add("Ⓤ", "\\u24CA", "&#9418;", "编号", "带圈大写字母", "u", "", "", "", "", "", "", "", "");
            dt.Rows.Add("Ⓥ", "\\u24CB", "&#9419;", "编号", "带圈大写字母", "v", "", "", "", "", "", "", "", "");
            dt.Rows.Add("Ⓦ", "\\u24CC", "&#9420;", "编号", "带圈大写字母", "w", "", "", "", "", "", "", "", "");
            dt.Rows.Add("Ⓧ", "\\u24CD", "&#9421;", "编号", "带圈大写字母", "x", "", "", "", "", "", "", "", "");
            dt.Rows.Add("Ⓨ", "\\u24CE", "&#9422;", "编号", "带圈大写字母", "y", "", "", "", "", "", "", "", "");
            dt.Rows.Add("Ⓩ", "\\u24CF", "&#9423;", "编号", "带圈小写字母", "z", "", "", "", "", "", "", "", "");
            dt.Rows.Add("ⓐ", "\\u24D0", "&#9424;", "编号", "带圈小写字母", "a", "", "", "", "", "", "", "", "");
            dt.Rows.Add("ⓑ", "\\u24D1", "&#9425;", "编号", "带圈小写字母", "b", "", "", "", "", "", "", "", "");
            dt.Rows.Add("ⓒ", "\\u24D2", "&#9426;", "编号", "带圈小写字母", "c", "", "", "", "", "", "", "", "");
            dt.Rows.Add("ⓓ", "\\u24D3", "&#9427;", "编号", "带圈小写字母", "d", "", "", "", "", "", "", "", "");
            dt.Rows.Add("ⓔ", "\\u24D4", "&#9428;", "编号", "带圈小写字母", "e", "", "", "", "", "", "", "", "");
            dt.Rows.Add("ⓕ", "\\u24D5", "&#9429;", "编号", "带圈小写字母", "f", "", "", "", "", "", "", "", "");
            dt.Rows.Add("ⓖ", "\\u24D6", "&#9430;", "编号", "带圈小写字母", "g", "", "", "", "", "", "", "", "");
            dt.Rows.Add("ⓗ", "\\u24D7", "&#9431;", "编号", "带圈小写字母", "h", "", "", "", "", "", "", "", "");
            dt.Rows.Add("ⓘ", "\\u24D8", "&#9432;", "编号", "带圈小写字母", "i", "", "", "", "", "", "", "", "");
            dt.Rows.Add("ⓙ", "\\u24D9", "&#9433;", "编号", "带圈小写字母", "j", "", "", "", "", "", "", "", "");
            dt.Rows.Add("ⓚ", "\\u24DA", "&#9434;", "编号", "带圈小写字母", "k", "", "", "", "", "", "", "", "");
            dt.Rows.Add("ⓛ", "\\u24DB", "&#9435;", "编号", "带圈小写字母", "l", "", "", "", "", "", "", "", "");
            dt.Rows.Add("ⓜ", "\\u24DC", "&#9436;", "编号", "带圈小写字母", "m", "", "", "", "", "", "", "", "");
            dt.Rows.Add("ⓝ", "\\u24DD", "&#9437;", "编号", "带圈小写字母", "n", "", "", "", "", "", "", "", "");
            dt.Rows.Add("ⓞ", "\\u24DE", "&#9438;", "编号", "带圈小写字母", "o", "", "", "", "", "", "", "", "");
            dt.Rows.Add("ⓟ", "\\u24DF", "&#9439;", "编号", "带圈小写字母", "p", "", "", "", "", "", "", "", "");
            dt.Rows.Add("ⓠ", "\\u24E0", "&#9440;", "编号", "带圈小写字母", "q", "", "", "", "", "", "", "", "");
            dt.Rows.Add("ⓡ", "\\u24E1", "&#9441;", "编号", "带圈小写字母", "r", "", "", "", "", "", "", "", "");
            dt.Rows.Add("ⓢ", "\\u24E2", "&#9442;", "编号", "带圈小写字母", "s", "", "", "", "", "", "", "", "");
            dt.Rows.Add("ⓣ", "\\u24E3", "&#9443;", "编号", "带圈小写字母", "t", "", "", "", "", "", "", "", "");
            dt.Rows.Add("ⓤ", "\\u24E4", "&#9444;", "编号", "带圈小写字母", "u", "", "", "", "", "", "", "", "");
            dt.Rows.Add("ⓥ", "\\u24E5", "&#9445;", "编号", "带圈小写字母", "v", "", "", "", "", "", "", "", "");
            dt.Rows.Add("ⓦ", "\\u24E6", "&#9446;", "编号", "带圈小写字母", "w", "", "", "", "", "", "", "", "");
            dt.Rows.Add("ⓧ", "\\u24E7", "&#9447;", "编号", "带圈小写字母", "x", "", "", "", "", "", "", "", "");
            dt.Rows.Add("ⓨ", "\\u24E8", "&#9448;", "编号", "带圈小写字母", "y", "", "", "", "", "", "", "", "");
            dt.Rows.Add("ⓩ", "\\u24E9", "&#9449;", "编号", "带圈小写字母", "z", "", "", "", "", "", "", "", "");
            dt.Rows.Add("⒜", "\\u249C", "&#9372;", "编号", "带括号小写字母", "a", "", "", "", "", "", "", "", "");
            dt.Rows.Add("⒝", "\\u249D", "&#9373;", "编号", "带括号小写字母", "b", "", "", "", "", "", "", "", "");
            dt.Rows.Add("⒞", "\\u249E", "&#9374;", "编号", "带括号小写字母", "c", "", "", "", "", "", "", "", "");
            dt.Rows.Add("⒟", "\\u249F", "&#9375;", "编号", "带括号小写字母", "d", "", "", "", "", "", "", "", "");
            dt.Rows.Add("⒠", "\\u24A0", "&#9376;", "编号", "带括号小写字母", "e", "", "", "", "", "", "", "", "");
            dt.Rows.Add("⒡", "\\u24A1", "&#9377;", "编号", "带括号小写字母", "f", "", "", "", "", "", "", "", "");
            dt.Rows.Add("⒢", "\\u24A2", "&#9378;", "编号", "带括号小写字母", "g", "", "", "", "", "", "", "", "");
            dt.Rows.Add("⒣", "\\u24A3", "&#9379;", "编号", "带括号小写字母", "h", "", "", "", "", "", "", "", "");
            dt.Rows.Add("⒤", "\\u24A4", "&#9380;", "编号", "带括号小写字母", "i", "", "", "", "", "", "", "", "");
            dt.Rows.Add("⒥", "\\u24A5", "&#9381;", "编号", "带括号小写字母", "j", "", "", "", "", "", "", "", "");
            dt.Rows.Add("⒦", "\\u24A6", "&#9382;", "编号", "带括号小写字母", "k", "", "", "", "", "", "", "", "");
            dt.Rows.Add("⒧", "\\u24A7", "&#9383;", "编号", "带括号小写字母", "l", "", "", "", "", "", "", "", "");
            dt.Rows.Add("⒨", "\\u24A8", "&#9384;", "编号", "带括号小写字母", "m", "", "", "", "", "", "", "", "");
            dt.Rows.Add("⒩", "\\u24A9", "&#9385;", "编号", "带括号小写字母", "n", "", "", "", "", "", "", "", "");
            dt.Rows.Add("⒪", "\\u24AA", "&#9386;", "编号", "带括号小写字母", "o", "", "", "", "", "", "", "", "");
            dt.Rows.Add("⒫", "\\u24AB", "&#9387;", "编号", "带括号小写字母", "p", "", "", "", "", "", "", "", "");
            dt.Rows.Add("⒬", "\\u24AC", "&#9388;", "编号", "带括号小写字母", "q", "", "", "", "", "", "", "", "");
            dt.Rows.Add("⒭", "\\u24AD", "&#9389;", "编号", "带括号小写字母", "r", "", "", "", "", "", "", "", "");
            dt.Rows.Add("⒮", "\\u24AE", "&#9390;", "编号", "带括号小写字母", "s", "", "", "", "", "", "", "", "");
            dt.Rows.Add("⒯", "\\u24AF", "&#9391;", "编号", "带括号小写字母", "t", "", "", "", "", "", "", "", "");
            dt.Rows.Add("⒰", "\\u24B0", "&#9392;", "编号", "带括号小写字母", "u", "", "", "", "", "", "", "", "");
            dt.Rows.Add("⒱", "\\u24B1", "&#9393;", "编号", "带括号小写字母", "v", "", "", "", "", "", "", "", "");
            dt.Rows.Add("⒲", "\\u24B2", "&#9394;", "编号", "带括号小写字母", "w", "", "", "", "", "", "", "", "");
            dt.Rows.Add("⒳", "\\u24B3", "&#9395;", "编号", "带括号小写字母", "x", "", "", "", "", "", "", "", "");
            dt.Rows.Add("⒴", "\\u24B4", "&#9396;", "编号", "带括号小写字母", "y", "", "", "", "", "", "", "", "");
            dt.Rows.Add("⒵", "\\u24B5", "&#9397;", "编号", "带括号小写字母", "z", "", "", "", "", "", "", "", "");
            #endregion
            string s = "①②③④⑤⑥⑦⑧⑨⑩⑪⑫⑬⑭⑮⑯⑰⑱⑲⑳⓪⓿❶❷❸❹❺❻❼❽❾❿⓫⓬⓭⓮⓯⓰⓱⓲⓳⓴⓵⓶⓷⓸⓹⓺⓻⓼⓽⓾㊀㊁㊂㊃㊄㊅㊆㊇㊈㊉㈠㈡㈢㈣㈤㈥㈦㈧㈨㈩⑴⑵⑶⑷⑸⑹⑺⑻⑼⑽⑾⑿⒀⒁⒂⒃⒄⒅⒆⒇⒈⒉⒊⒋⒌⒍⒎⒏⒐⒑⒒⒓⒔⒕⒖⒗⒘⒙⒚⒛ⅠⅡⅢⅣⅤⅥⅦⅧⅨⅩⅪⅫⅰⅱⅲⅳⅴⅵⅶⅷⅸⅹⒶⒷⒸⒹⒺⒻⒼⒽⒾⒿⓀⓁⓂⓃⓄⓅⓆⓇⓈⓉⓊⓋⓌⓍⓎⓏⓐⓑⓒⓓⓔⓕⓖⓗⓘⓙⓚⓛⓜⓝⓞⓟⓠⓡⓢⓣⓤⓥⓦⓧⓨⓩ⒜⒝⒞⒟⒠⒡⒢⒣⒤⒥⒦⒧⒨⒩⒪⒫⒬⒭⒮⒯⒰⒱⒲⒳⒴⒵";
            StringBuilder sb = new StringBuilder();
            foreach(char c in s)
            {
                sb.AppendLine($"dt.Rows.Add(\"{c}\",\"\\\\u{((int)c).ToString("X")}\",\"&#{(int)c};\",\"编号\",\"\",\"\",\"\",\"\",\"\",\"\",\"\",\"\",\"\",\"\");");
            }
            s = sb.ToString();
            dgv.AutoGenerateColumns = false;
            dgv.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).SetValue(dgv, true, null);
            dgv.DataSource = dt;
        }

        private void tstSearch_TextChanged(object sender, EventArgs e)
        {
            dt.DefaultView.RowFilter = String.Format("s1 like '%{0}%' or s2 like '%{0}%' or s3 like '%{0}%' or s4 like '%{0}%' or s5 like '%{0}%' or s6 like '%{0}%' or s7 like '%{0}%' or s8 like '%{0}%' or s9 like '%{0}%' or s10 like '%{0}%' or s11 like '%{0}%' or s12 like '%{0}%' or s13 like '%{0}%' or s14 like '%{0}%'", tstSearch.Text.Trim().Replace("'","''").Replace("%","[%]").Replace("*","[*]").Replace("[","[[]"));
        }

        private void tsdCopy_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                Clipboard.SetText(dgv.CurrentRow.Cells[e.ClickedItem.ImageIndex].Value.ToString());
            }
            catch
            {

            }
        }
    }
}