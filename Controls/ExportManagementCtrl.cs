using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataStructure;
using NPOI.HSSF.UserModel;
using NPOI.HPSF;
using NPOI.POIFS.FileSystem;
using NPOI.SS.Util;
using NPOI.SS.UserModel;
using System.IO;
using MSWord = Microsoft.Office.Interop.Word;
using MSExcel = Microsoft.Office.Interop.Excel;
using System.Reflection;
using Microsoft.Office.Interop.Word;
using System.Data;

namespace Controls
{
    public static class ExportManagementCtrl
    {
        /// <summary>
        /// 导出指定的考评表到Excel，导出成功返回true，否则返回false
        /// </summary> 
        /// <param name="fileName">生成文件的文件名</param>
        /// <param name="evaluateTable">考核表</param>
        /// <param name="?"></param>
        /// <returns></returns>
        public static bool ExportEvaluateTable(ref string fileName, EvaluateTable evaluateTable, ref string exception)
        {
            HSSFWorkbook hssfworkbook = new HSSFWorkbook();
            ISheet sheet = hssfworkbook.CreateSheet("考核表");

            CellRangeAddress region;


            //设置宽度
            sheet.SetColumnWidth(0, 4 * 256);
            sheet.SetColumnWidth(1, 7 * 256);
            sheet.SetColumnWidth(2, 7 * 256);
            sheet.SetColumnWidth(3, 14 * 256);
            sheet.SetColumnWidth(4, 18 * 256);
            sheet.SetColumnWidth(5, 18 * 256);
            sheet.SetColumnWidth(6, 18 * 256);
            sheet.SetColumnWidth(7, 18 * 256);
            sheet.SetColumnWidth(8, 6 * 256);
            sheet.SetColumnWidth(9, 12 * 256);
            sheet.SetColumnWidth(10, 7 * 256);
            sheet.SetColumnWidth(11, 11 * 256);

            //设置格式
            ICellStyle titleStyle = hssfworkbook.CreateCellStyle();
            titleStyle.Alignment = HorizontalAlignment.CENTER;
            titleStyle.VerticalAlignment = VerticalAlignment.CENTER;
            IFont titleFont = hssfworkbook.CreateFont();
            titleFont.FontName = "宋体";
            titleFont.FontHeightInPoints = 18;
            titleFont.Boldweight = (short)FontBoldWeight.BOLD;
            titleStyle.SetFont(titleFont);

            ICellStyle normalBoldCenterStyle = hssfworkbook.CreateCellStyle();
            normalBoldCenterStyle.Alignment = HorizontalAlignment.CENTER;
            normalBoldCenterStyle.VerticalAlignment = VerticalAlignment.CENTER;
            IFont normalBoldCenterFont = hssfworkbook.CreateFont();
            normalBoldCenterFont.FontName = "宋体";
            normalBoldCenterFont.FontHeightInPoints = 11;
            normalBoldCenterFont.Boldweight = (short)FontBoldWeight.BOLD;
            normalBoldCenterStyle.SetFont(normalBoldCenterFont);
            normalBoldCenterStyle.WrapText = true;
            normalBoldCenterStyle.BorderTop = BorderStyle.THIN;
            normalBoldCenterStyle.BorderBottom = BorderStyle.THIN;
            normalBoldCenterStyle.BorderLeft = BorderStyle.THIN;
            normalBoldCenterStyle.BorderRight = BorderStyle.THIN;

            ICellStyle normalBoldLeftStyle = hssfworkbook.CreateCellStyle();
            normalBoldLeftStyle.Alignment = HorizontalAlignment.LEFT;
            normalBoldLeftStyle.VerticalAlignment = VerticalAlignment.CENTER;
            IFont normalBoldLeftFont = hssfworkbook.CreateFont();
            normalBoldLeftFont.FontName = "宋体";
            normalBoldLeftFont.FontHeightInPoints = 11;
            normalBoldLeftFont.Boldweight = (short)FontBoldWeight.BOLD;
            normalBoldLeftStyle.SetFont(normalBoldLeftFont);
            normalBoldLeftStyle.WrapText = true;

            ICellStyle normalBoldRightStyle = hssfworkbook.CreateCellStyle();
            normalBoldRightStyle.Alignment = HorizontalAlignment.RIGHT;
            normalBoldRightStyle.VerticalAlignment = VerticalAlignment.CENTER;
            IFont normalBoldRightFont = hssfworkbook.CreateFont();
            normalBoldRightFont.FontName = "宋体";
            normalBoldRightFont.FontHeightInPoints = 11;
            normalBoldRightFont.Boldweight = (short)FontBoldWeight.BOLD;
            normalBoldRightStyle.SetFont(normalBoldRightFont);
            normalBoldRightStyle.WrapText = true;

            ICellStyle normalStyle = hssfworkbook.CreateCellStyle();
            normalStyle.Alignment = HorizontalAlignment.LEFT;
            normalStyle.VerticalAlignment = VerticalAlignment.TOP;
            IFont normalFont = hssfworkbook.CreateFont();
            normalFont.FontName = "宋体";
            normalFont.FontHeightInPoints = 9;
            normalStyle.SetFont(normalFont);
            normalStyle.WrapText = true;
            normalStyle.BorderTop = BorderStyle.THIN;
            normalStyle.BorderBottom = BorderStyle.THIN;
            normalStyle.BorderLeft = BorderStyle.THIN;
            normalStyle.BorderRight = BorderStyle.THIN;

            ICellStyle normalStyleNoBorder = hssfworkbook.CreateCellStyle();
            normalStyleNoBorder.Alignment = HorizontalAlignment.LEFT;
            normalStyleNoBorder.VerticalAlignment = VerticalAlignment.TOP;
            IFont normalFontnormalStyleNoBorder = hssfworkbook.CreateFont();
            normalFontnormalStyleNoBorder.FontName = "宋体";
            normalFontnormalStyleNoBorder.FontHeightInPoints = 9;
            normalStyleNoBorder.SetFont(normalFont);
            normalStyleNoBorder.WrapText = true;

            ICellStyle normalCenterStyle = hssfworkbook.CreateCellStyle();
            normalCenterStyle.Alignment = HorizontalAlignment.CENTER;
            normalCenterStyle.VerticalAlignment = VerticalAlignment.CENTER;
            IFont normalCenterFont = hssfworkbook.CreateFont();
            normalCenterFont.FontName = "宋体";
            normalCenterFont.FontHeightInPoints = 9;
            normalCenterStyle.SetFont(normalCenterFont);
            normalCenterStyle.WrapText = true;
            normalCenterStyle.BorderTop = BorderStyle.THIN;
            normalCenterStyle.BorderBottom = BorderStyle.THIN;
            normalCenterStyle.BorderLeft = BorderStyle.THIN;
            normalCenterStyle.BorderRight = BorderStyle.THIN;

            //标题行
            IRow row0 = sheet.CreateRow(0);
            row0.HeightInPoints = 32;
            ICell cell00 = row0.CreateCell(0);
            cell00.SetCellValue("同济大学派遣员工考核表");
            cell00.CellStyle = titleStyle;
            region = new CellRangeAddress(0, 0, 0, 11);
            sheet.AddMergedRegion(region);

            //表头第一行
            IRow row1 = sheet.CreateRow(1);
            row1.HeightInPoints = 20;
            ICell cell10 = row1.CreateCell(0);
            cell10.SetCellValue("被考核人姓名：" + evaluateTable.EvaluatedName + "  岗位名称：" + evaluateTable.PostName + "  用工部门：" + evaluateTable.LaborDep + "  用工单位：同济大学" + evaluateTable.LaborUnit);
            cell10.CellStyle = normalBoldLeftStyle;
            region = new CellRangeAddress(1, 1, 0, 11);

            sheet.AddMergedRegion(region);

            //表头第二行
            IRow row2 = sheet.CreateRow(2);
            row2.HeightInPoints = 20;
            ICell cell20 = row2.CreateCell(0);
            cell20.SetCellValue("考核时间段：" + evaluateTable.StartTime + " ~ " + evaluateTable.StopTime + "  考核日期：      考评者类型：□领导；□同事；□下属；□服务对象");
            cell20.CellStyle = normalBoldLeftStyle;
            region = new CellRangeAddress(2, 2, 0, 11);
            sheet.AddMergedRegion(region);

            //表头第三行
            IRow row3 = sheet.CreateRow(3);
            row3.HeightInPoints = 20;
            ICell cell30 = row3.CreateCell(0);
            cell30.SetCellValue("经本人与所在用工单位协商一致，同意将以下考核指标作为对本人的年度考核依据。");
            cell30.CellStyle = normalBoldLeftStyle;
            region = new CellRangeAddress(3, 3, 0, 11);
            sheet.AddMergedRegion(region);

            //表头第四行
            IRow row4 = sheet.CreateRow(4);
            row4.HeightInPoints = 20;
            ICell cell40 = row4.CreateCell(0);
            cell40.SetCellValue("确认人签字：          日期：          ");
            cell40.CellStyle = normalBoldRightStyle;
            region = new CellRangeAddress(4, 4, 0, 11);
            sheet.AddMergedRegion(region);

            //表格第一行
            IRow row5 = sheet.CreateRow(5);

            ICell cell50 = row5.CreateCell(0);
            cell50.SetCellValue("指标体系");
            cell50.CellStyle = normalBoldCenterStyle;
            region = new CellRangeAddress(5, 5, 0, 3);
            sheet.AddMergedRegion(region);
            ((HSSFSheet)sheet).SetEnclosedBorderOfRegion(region, BorderStyle.THIN, NPOI.HSSF.Util.HSSFColor.BLACK.index);

            ICell cell51 = row5.CreateCell(4);
            cell51.SetCellValue("指标描述及分值");
            cell51.CellStyle = normalBoldCenterStyle;
            region = new CellRangeAddress(5, 5, 4, 7);
            sheet.AddMergedRegion(region);
            ((HSSFSheet)sheet).SetEnclosedBorderOfRegion(region, BorderStyle.THIN, NPOI.HSSF.Util.HSSFColor.BLACK.index);

            ICell cell52 = row5.CreateCell(8);
            cell52.SetCellValue("得分");
            cell52.CellStyle = normalBoldCenterStyle;

            ICell cell53 = row5.CreateCell(9);
            cell53.SetCellValue("每项指标得分的平均值");
            cell53.CellStyle = normalBoldCenterStyle;

            ICell cell54 = row5.CreateCell(10);
            cell54.SetCellValue("权重");
            cell54.CellStyle = normalBoldCenterStyle;

            ICell cell55 = row5.CreateCell(11);
            cell55.SetCellValue("小计");
            cell55.CellStyle = normalBoldCenterStyle;

            //关键绩效指标标题列
            IRow rowKey = sheet.CreateRow(6);
            int keyCount = evaluateTable.KeyResponse.Count + evaluateTable.KeyQualify.Count + evaluateTable.KeyAttitude.Count;

            ICell cell61 = rowKey.CreateCell(0);
            cell61.SetCellValue("一");
            cell61.CellStyle = normalBoldCenterStyle;
            region = new CellRangeAddress(6, 6 + keyCount * 2 - 1, 0, 0);
            sheet.AddMergedRegion(region);
            ((HSSFSheet)sheet).SetEnclosedBorderOfRegion(region, BorderStyle.THIN, NPOI.HSSF.Util.HSSFColor.BLACK.index);

            ICell cell62 = rowKey.CreateCell(1);
            cell62.SetCellValue("关键绩效指标");
            cell62.CellStyle = normalBoldCenterStyle;
            region = new CellRangeAddress(6, 6 + keyCount * 2 - 1, 1, 1);
            sheet.AddMergedRegion(region);
            ((HSSFSheet)sheet).SetEnclosedBorderOfRegion(region, BorderStyle.THIN, NPOI.HSSF.Util.HSSFColor.BLACK.index);

            //岗位职责指标标题列
            IRow rowResponse = sheet.CreateRow(6 + keyCount * 2);

            ICell cellResponse1 = rowResponse.CreateCell(0);
            cellResponse1.SetCellValue("二");
            cellResponse1.CellStyle = normalBoldCenterStyle;
            region = new CellRangeAddress(6 + keyCount * 2, 6 + (keyCount + evaluateTable.Response.Count) * 2 - 1, 0, 0);
            sheet.AddMergedRegion(region);
            ((HSSFSheet)sheet).SetEnclosedBorderOfRegion(region, BorderStyle.THIN, NPOI.HSSF.Util.HSSFColor.BLACK.index);

            ICell cellResponse2 = rowResponse.CreateCell(1);
            cellResponse2.SetCellValue("岗位职责指标");
            cellResponse2.CellStyle = normalBoldCenterStyle;
            region = new CellRangeAddress(6 + keyCount * 2, 6 + (keyCount + evaluateTable.Response.Count) * 2 - 1, 1, 1);
            sheet.AddMergedRegion(region);
            ((HSSFSheet)sheet).SetEnclosedBorderOfRegion(region, BorderStyle.THIN, NPOI.HSSF.Util.HSSFColor.BLACK.index);

            //岗位胜任能力指标标题列
            IRow rowQualify = sheet.CreateRow(6 + (keyCount + evaluateTable.Response.Count) * 2);

            ICell cellQualify1 = rowQualify.CreateCell(0);
            cellQualify1.SetCellValue("三");
            cellQualify1.CellStyle = normalBoldCenterStyle;
            region = new CellRangeAddress(6 + (keyCount + evaluateTable.Response.Count) * 2, 6 + (keyCount + evaluateTable.Response.Count + evaluateTable.Qualify.Count) * 2 - 1, 0, 0);
            sheet.AddMergedRegion(region);
            ((HSSFSheet)sheet).SetEnclosedBorderOfRegion(region, BorderStyle.THIN, NPOI.HSSF.Util.HSSFColor.BLACK.index);

            ICell cellQualify2 = rowQualify.CreateCell(1);
            cellQualify2.SetCellValue("岗位胜任能力指标");
            cellQualify2.CellStyle = normalBoldCenterStyle;
            region = new CellRangeAddress(6 + (keyCount + evaluateTable.Response.Count) * 2, 6 + (keyCount + evaluateTable.Response.Count + evaluateTable.Qualify.Count) * 2 - 1, 1, 1);
            sheet.AddMergedRegion(region);
            ((HSSFSheet)sheet).SetEnclosedBorderOfRegion(region, BorderStyle.THIN, NPOI.HSSF.Util.HSSFColor.BLACK.index);

            //工作态度指标标题列
            IRow rowAttitude = sheet.CreateRow(6 + (keyCount + evaluateTable.Response.Count + evaluateTable.Qualify.Count) * 2);

            ICell cellAttitude1 = rowAttitude.CreateCell(0);
            cellAttitude1.SetCellValue("四");
            cellAttitude1.CellStyle = normalBoldCenterStyle;
            region = new CellRangeAddress(6 + (keyCount + evaluateTable.Response.Count + evaluateTable.Qualify.Count) * 2, 6 + (keyCount + evaluateTable.Response.Count + evaluateTable.Qualify.Count + evaluateTable.Attitude.Count) * 2 - 1, 0, 0);
            sheet.AddMergedRegion(region);
            ((HSSFSheet)sheet).SetEnclosedBorderOfRegion(region, BorderStyle.THIN, NPOI.HSSF.Util.HSSFColor.BLACK.index);

            ICell cellAttitude2 = rowAttitude.CreateCell(1);
            cellAttitude2.SetCellValue("工作态度指标");
            cellAttitude2.CellStyle = normalBoldCenterStyle;
            region = new CellRangeAddress(6 + (keyCount + evaluateTable.Response.Count + evaluateTable.Qualify.Count) * 2, 6 + (keyCount + evaluateTable.Response.Count + evaluateTable.Qualify.Count + evaluateTable.Attitude.Count) * 2 - 1, 1, 1);
            sheet.AddMergedRegion(region);
            ((HSSFSheet)sheet).SetEnclosedBorderOfRegion(region, BorderStyle.THIN, NPOI.HSSF.Util.HSSFColor.BLACK.index);

            //否决指标标题列
            IRow rowReject = sheet.CreateRow(6 + (keyCount + evaluateTable.Response.Count + evaluateTable.Qualify.Count + evaluateTable.Attitude.Count) * 2);

            ICell cellReject1 = rowReject.CreateCell(0);
            cellReject1.SetCellValue("五");
            cellReject1.CellStyle = normalBoldCenterStyle;
            region = new CellRangeAddress(6 + (keyCount + evaluateTable.Response.Count + evaluateTable.Qualify.Count + evaluateTable.Attitude.Count) * 2, 6 + (keyCount + evaluateTable.Response.Count + evaluateTable.Qualify.Count + evaluateTable.Attitude.Count) * 2 + 1, 0, 0);
            sheet.AddMergedRegion(region);
            ((HSSFSheet)sheet).SetEnclosedBorderOfRegion(region, BorderStyle.THIN, NPOI.HSSF.Util.HSSFColor.BLACK.index);

            ICell cellReject2 = rowReject.CreateCell(1);
            cellReject2.SetCellValue("否决指标");
            cellReject2.CellStyle = normalBoldCenterStyle;
            region = new CellRangeAddress(6 + (keyCount + evaluateTable.Response.Count + evaluateTable.Qualify.Count + evaluateTable.Attitude.Count) * 2, 6 + (keyCount + evaluateTable.Response.Count + evaluateTable.Qualify.Count + evaluateTable.Attitude.Count) * 2 + 1, 1, 1);
            sheet.AddMergedRegion(region);
            ((HSSFSheet)sheet).SetEnclosedBorderOfRegion(region, BorderStyle.THIN, NPOI.HSSF.Util.HSSFColor.BLACK.index);

            //关键岗位职责指标标题列
            IRow rowKeyResponse = sheet.GetRow(6);

            ICell cellKeyResponse = rowKeyResponse.CreateCell(2);
            cellKeyResponse.SetCellValue("关键岗位职责指标");
            cellKeyResponse.CellStyle = normalBoldCenterStyle;
            region = new CellRangeAddress(6, 6 + evaluateTable.KeyResponse.Count * 2 - 1, 2, 2);
            sheet.AddMergedRegion(region);
            ((HSSFSheet)sheet).SetEnclosedBorderOfRegion(region, BorderStyle.THIN, NPOI.HSSF.Util.HSSFColor.BLACK.index);

            //关键岗位胜任能力指标标题列
            IRow rowKeyQualify = sheet.GetRow(6 + evaluateTable.KeyResponse.Count * 2);

            ICell cellKeyQualify = rowKeyQualify.CreateCell(2);
            cellKeyQualify.SetCellValue("关键岗位胜任能力指标");
            cellKeyQualify.CellStyle = normalBoldCenterStyle;
            region = new CellRangeAddress(6 + evaluateTable.KeyResponse.Count * 2, 6 + (evaluateTable.KeyResponse.Count + evaluateTable.KeyQualify.Count) * 2 - 1, 2, 2);
            sheet.AddMergedRegion(region);
            ((HSSFSheet)sheet).SetEnclosedBorderOfRegion(region, BorderStyle.THIN, NPOI.HSSF.Util.HSSFColor.BLACK.index);

            //关键工作态度指标标题列
            IRow rowKeyAttitude = sheet.GetRow(6 + (evaluateTable.KeyResponse.Count + evaluateTable.KeyQualify.Count) * 2);

            ICell cellKeyAttitude = rowKeyAttitude.CreateCell(2);
            cellKeyAttitude.SetCellValue("关键工作态度指标");
            cellKeyAttitude.CellStyle = normalBoldCenterStyle;
            region = new CellRangeAddress(6 + (evaluateTable.KeyResponse.Count + evaluateTable.KeyQualify.Count) * 2, 6 + (evaluateTable.KeyResponse.Count + evaluateTable.KeyQualify.Count + evaluateTable.KeyAttitude.Count) * 2 - 1, 2, 2);
            sheet.AddMergedRegion(region);
            ((HSSFSheet)sheet).SetEnclosedBorderOfRegion(region, BorderStyle.THIN, NPOI.HSSF.Util.HSSFColor.BLACK.index);

            //关键岗位职责指标
            for (int index = 0; index < evaluateTable.KeyResponse.Count; index++)
            {
                IRow row;
                if (index == 0)
                    row = sheet.GetRow(6);
                else
                    row = sheet.GetRow(6 + index * 2);
                int charCount = evaluateTable.KeyResponse[index].Content[0].Length;
                if (charCount / 41 == 0)
                    row.HeightInPoints = 16;
                else
                    row.HeightInPoints = 12 * (charCount / 41 + 1);
                ICell cell1 = row.CreateCell(3);
                cell1.SetCellValue(evaluateTable.KeyResponse[index].Title);
                cell1.CellStyle = normalCenterStyle;
                region = new CellRangeAddress(6 + index * 2, 6 + index * 2 + 1, 3, 3);
                sheet.AddMergedRegion(region);
                ((HSSFSheet)sheet).SetEnclosedBorderOfRegion(region, BorderStyle.THIN, NPOI.HSSF.Util.HSSFColor.BLACK.index);

                ICell cell2 = row.CreateCell(4);
                cell2.SetCellValue(evaluateTable.KeyResponse[index].Content[0]);
                cell2.CellStyle = normalStyle;
                region = new CellRangeAddress(6 + index * 2, 6 + index * 2, 4, 7);
                sheet.AddMergedRegion(region);
                ((HSSFSheet)sheet).SetEnclosedBorderOfRegion(region, BorderStyle.THIN, NPOI.HSSF.Util.HSSFColor.BLACK.index);

                genScoreGradeRow(sheet, 7 + index * 2, 4, normalCenterStyle);
            }

            //关键岗位胜任能力指标
            for (int index = 0; index < evaluateTable.KeyQualify.Count; index++)
            {
                IRow row;
                if (index == 0)
                    row = sheet.GetRow(6 + 2 * evaluateTable.KeyResponse.Count);
                else
                    row = sheet.GetRow(6 + 2 * (evaluateTable.KeyResponse.Count + index));
                int charCount = getLongestContent(evaluateTable.KeyQualify[index].Content);
                if (charCount / 10 == 0)
                    row.HeightInPoints = 16;
                else
                    row.HeightInPoints = 12 * (charCount / 10 + 1);
                ICell cell1 = row.CreateCell(3);
                cell1.SetCellValue(evaluateTable.KeyQualify[index].Title);
                cell1.CellStyle = normalCenterStyle;
                region = new CellRangeAddress(6 + 2 * (evaluateTable.KeyResponse.Count + index), 6 + 2 * (evaluateTable.KeyResponse.Count + index) + 1, 3, 3);
                sheet.AddMergedRegion(region);
                ((HSSFSheet)sheet).SetEnclosedBorderOfRegion(region, BorderStyle.THIN, NPOI.HSSF.Util.HSSFColor.BLACK.index);

                ICell cell2 = row.CreateCell(4);
                cell2.SetCellValue(evaluateTable.KeyQualify[index].Content[0]);
                cell2.CellStyle = normalStyle;

                ICell cell3 = row.CreateCell(5);
                cell3.SetCellValue(evaluateTable.KeyQualify[index].Content[1]);
                cell3.CellStyle = normalStyle;

                ICell cell4 = row.CreateCell(6);
                cell4.SetCellValue(evaluateTable.KeyQualify[index].Content[2]);
                cell4.CellStyle = normalStyle;

                ICell cell5 = row.CreateCell(7);
                cell5.SetCellValue(evaluateTable.KeyQualify[index].Content[3]);
                cell5.CellStyle = normalStyle;


                genScoreGradeRow(sheet, 7 + 2 * (evaluateTable.KeyResponse.Count + index), 4, normalCenterStyle);
            }

            //关键工作态度指标
            for (int index = 0; index < evaluateTable.KeyAttitude.Count; index++)
            {
                IRow row;
                if (index == 0)
                    row = sheet.GetRow(6 + 2 * (evaluateTable.KeyResponse.Count + evaluateTable.KeyQualify.Count));
                else
                    row = sheet.GetRow(6 + 2 * (evaluateTable.KeyResponse.Count + evaluateTable.KeyQualify.Count + index));
                int charCount = getLongestContent(evaluateTable.KeyAttitude[index].Content);
                if (charCount / 10 == 0)
                    row.HeightInPoints = 16;
                else
                    row.HeightInPoints = 12 * (charCount / 10 + 1);
                ICell cell1 = row.CreateCell(3);
                cell1.SetCellValue(evaluateTable.KeyAttitude[index].Title);
                cell1.CellStyle = normalCenterStyle;
                region = new CellRangeAddress(6 + (index + evaluateTable.KeyResponse.Count + evaluateTable.KeyQualify.Count) * 2, 6 + (index + evaluateTable.KeyResponse.Count + evaluateTable.KeyQualify.Count) * 2 + 1, 3, 3);
                sheet.AddMergedRegion(region);
                ((HSSFSheet)sheet).SetEnclosedBorderOfRegion(region, BorderStyle.THIN, NPOI.HSSF.Util.HSSFColor.BLACK.index);

                ICell cell2 = row.CreateCell(4);
                cell2.SetCellValue(evaluateTable.KeyAttitude[index].Content[0]);
                cell2.CellStyle = normalStyle;

                ICell cell3 = row.CreateCell(5);
                cell3.SetCellValue(evaluateTable.KeyAttitude[index].Content[1]);
                cell3.CellStyle = normalStyle;

                ICell cell4 = row.CreateCell(6);
                cell4.SetCellValue(evaluateTable.KeyAttitude[index].Content[2]);
                cell4.CellStyle = normalStyle;

                ICell cell5 = row.CreateCell(7);
                cell5.SetCellValue(evaluateTable.KeyAttitude[index].Content[3]);
                cell5.CellStyle = normalStyle;


                genScoreGradeRow(sheet, 7 + 2 * (evaluateTable.KeyResponse.Count + evaluateTable.KeyQualify.Count + index), 4, normalCenterStyle);
            }

            //岗位责任指标
            for (int index = 0; index < evaluateTable.Response.Count; index++)
            {
                IRow row;
                if (index == 0)
                    row = sheet.GetRow(6 + keyCount * 2);
                else
                    row = sheet.GetRow(6 + (keyCount + index) * 2);
                int charCount = evaluateTable.Response[index].Content[0].Length;
                if (charCount / 41 == 0)
                    row.HeightInPoints = 16;
                else
                    row.HeightInPoints = 12 * (charCount / 41 + 1);
                ICell cell1 = row.CreateCell(2);
                cell1.SetCellValue(evaluateTable.Response[index].Title);
                cell1.CellStyle = normalCenterStyle;
                region = new CellRangeAddress(6 + (keyCount + index) * 2, 6 + (keyCount + index) * 2 + 1, 2, 3);
                sheet.AddMergedRegion(region);
                ((HSSFSheet)sheet).SetEnclosedBorderOfRegion(region, BorderStyle.THIN, NPOI.HSSF.Util.HSSFColor.BLACK.index);

                ICell cell2 = row.CreateCell(4);
                cell2.SetCellValue(evaluateTable.Response[index].Content[0]);
                cell2.CellStyle = normalStyle;
                region = new CellRangeAddress(6 + (keyCount + index) * 2, 6 + (keyCount + index) * 2, 4, 7);
                sheet.AddMergedRegion(region);
                ((HSSFSheet)sheet).SetEnclosedBorderOfRegion(region, BorderStyle.THIN, NPOI.HSSF.Util.HSSFColor.BLACK.index);

                genScoreGradeRow(sheet, 7 + (keyCount + index) * 2, 4, normalCenterStyle);
            }

            //岗位胜任能力指标
            for (int index = 0; index < evaluateTable.Qualify.Count; index++)
            {
                IRow row;
                if (index == 0)
                    row = sheet.GetRow(6 + 2 * (keyCount + evaluateTable.Response.Count));
                else
                    row = sheet.GetRow(6 + 2 * (keyCount + evaluateTable.Response.Count + index));
                int charCount = getLongestContent(evaluateTable.Qualify[index].Content);
                if (charCount / 10 == 0)
                    row.HeightInPoints = 16;
                else
                    row.HeightInPoints = 12 * (charCount / 10 + 1);
                ICell cell1 = row.CreateCell(2);
                cell1.SetCellValue(evaluateTable.Qualify[index].Title);
                cell1.CellStyle = normalCenterStyle;
                region = new CellRangeAddress(6 + (keyCount + index + evaluateTable.Response.Count) * 2, 6 + (keyCount + index + evaluateTable.Response.Count) * 2 + 1, 2, 3);
                sheet.AddMergedRegion(region);
                ((HSSFSheet)sheet).SetEnclosedBorderOfRegion(region, BorderStyle.THIN, NPOI.HSSF.Util.HSSFColor.BLACK.index);

                ICell cell2 = row.CreateCell(4);
                cell2.SetCellValue(evaluateTable.Qualify[index].Content[0]);
                cell2.CellStyle = normalStyle;

                ICell cell3 = row.CreateCell(5);
                cell3.SetCellValue(evaluateTable.Qualify[index].Content[1]);
                cell3.CellStyle = normalStyle;

                ICell cell4 = row.CreateCell(6);
                cell4.SetCellValue(evaluateTable.Qualify[index].Content[2]);
                cell4.CellStyle = normalStyle;

                ICell cell5 = row.CreateCell(7);
                cell5.SetCellValue(evaluateTable.Qualify[index].Content[3]);
                cell5.CellStyle = normalStyle;


                genScoreGradeRow(sheet, 7 + 2 * (keyCount + evaluateTable.Response.Count + index), 4, normalCenterStyle);
            }

            //工作态度指标
            for (int index = 0; index < evaluateTable.Attitude.Count; index++)
            {
                IRow row;
                if (index == 0)
                    row = sheet.GetRow(6 + 2 * (keyCount + evaluateTable.Response.Count + evaluateTable.Qualify.Count));
                else
                    row = sheet.GetRow(6 + 2 * (keyCount + evaluateTable.Response.Count + evaluateTable.Qualify.Count + index));
                int charCount = getLongestContent(evaluateTable.Attitude[index].Content);
                if (charCount / 10 == 0)
                    row.HeightInPoints = 16;
                else
                    row.HeightInPoints = 12 * (charCount / 10 + 1);
                ICell cell1 = row.CreateCell(2);
                cell1.SetCellValue(evaluateTable.Attitude[index].Title);
                cell1.CellStyle = normalCenterStyle;
                region = new CellRangeAddress(6 + (keyCount + index + evaluateTable.Response.Count + evaluateTable.Qualify.Count) * 2, 6 + (keyCount + index + evaluateTable.Response.Count + evaluateTable.Qualify.Count) * 2 + 1, 2, 3);
                sheet.AddMergedRegion(region);
                ((HSSFSheet)sheet).SetEnclosedBorderOfRegion(region, BorderStyle.THIN, NPOI.HSSF.Util.HSSFColor.BLACK.index);

                ICell cell2 = row.CreateCell(4);
                cell2.SetCellValue(evaluateTable.Attitude[index].Content[0]);
                cell2.CellStyle = normalStyle;

                ICell cell3 = row.CreateCell(5);
                cell3.SetCellValue(evaluateTable.Attitude[index].Content[1]);
                cell3.CellStyle = normalStyle;

                ICell cell4 = row.CreateCell(6);
                cell4.SetCellValue(evaluateTable.Attitude[index].Content[2]);
                cell4.CellStyle = normalStyle;

                ICell cell5 = row.CreateCell(7);
                cell5.SetCellValue(evaluateTable.Attitude[index].Content[3]);
                cell5.CellStyle = normalStyle;


                genScoreGradeRow(sheet, 7 + 2 * (keyCount + evaluateTable.Response.Count + evaluateTable.Qualify.Count + index), 4, normalCenterStyle);
            }

            ////否决指标
            IRow rowReject1 = sheet.GetRow(6 + (keyCount + evaluateTable.Response.Count + evaluateTable.Qualify.Count + evaluateTable.Attitude.Count) * 2);
            //int rejectLength1 = evaluateTable.Reject[0].Content[0].Length;
            //if (rejectLength1 / 41 == 0)
            //    rowReject1.HeightInPoints = 16;
            //else
            rowReject1.HeightInPoints = 12 * 7;

            ICell cellReject1Ti1tle = rowReject1.CreateCell(2);
            cellReject1Ti1tle.SetCellValue("否决指标");
            cellReject1Ti1tle.CellStyle = normalCenterStyle;
            region = new CellRangeAddress(6 + (keyCount + evaluateTable.Response.Count + evaluateTable.Qualify.Count + evaluateTable.Attitude.Count) * 2, 6 + (keyCount + evaluateTable.Response.Count + evaluateTable.Qualify.Count + evaluateTable.Attitude.Count) * 2, 2, 3);
            sheet.AddMergedRegion(region);
            ((HSSFSheet)sheet).SetEnclosedBorderOfRegion(region, BorderStyle.THIN, NPOI.HSSF.Util.HSSFColor.BLACK.index);

            ICell cellReject1Content = rowReject1.CreateCell(4);
            cellReject1Content.SetCellValue("累计旷工3天以上的；\n严重失职，营私舞弊，给本单位造成3000元以上经济损失或者其它严重后果的；\n同时与其他用人单位建立劳动关系，对完成本单位工作任务造成严重影响，或者经本单位提出，拒不改正的；\n违背职业道德，行贿、受贿价值超过3000元以上的；\n被依法追究刑事责任的；");
            cellReject1Content.CellStyle = normalStyle;
            region = new CellRangeAddress(6 + (keyCount + evaluateTable.Response.Count + evaluateTable.Qualify.Count + evaluateTable.Attitude.Count) * 2, 6 + (keyCount + evaluateTable.Response.Count + evaluateTable.Qualify.Count + evaluateTable.Attitude.Count) * 2, 4, 6);
            sheet.AddMergedRegion(region);
            ((HSSFSheet)sheet).SetEnclosedBorderOfRegion(region, BorderStyle.THIN, NPOI.HSSF.Util.HSSFColor.BLACK.index);

            ICell cellRejectScoreGrade = rowReject1.CreateCell(7);
            cellRejectScoreGrade.SetCellValue("-100或0");
            cellRejectScoreGrade.CellStyle = normalCenterStyle;
            region = new CellRangeAddress(6 + (keyCount + evaluateTable.Response.Count + evaluateTable.Qualify.Count + evaluateTable.Attitude.Count) * 2, 6 + (keyCount + evaluateTable.Response.Count + evaluateTable.Qualify.Count + evaluateTable.Attitude.Count) * 2 + 1, 7, 7);
            sheet.AddMergedRegion(region);
            ((HSSFSheet)sheet).SetEnclosedBorderOfRegion(region, BorderStyle.THIN, NPOI.HSSF.Util.HSSFColor.BLACK.index);

            IRow rowReject2 = sheet.GetRow(6 + (keyCount + evaluateTable.Response.Count + evaluateTable.Qualify.Count + evaluateTable.Attitude.Count) * 2 + 1);
            int rejectLength2 = evaluateTable.Reject[0].Content[0].Length;
            if (rejectLength2 / 41 == 0)
                rowReject2.HeightInPoints = 16;
            else
                rowReject2.HeightInPoints = 12 * (rejectLength2 / 41 + 1);

            ICell cellReject2Ti1tle = rowReject2.CreateCell(2);
            cellReject2Ti1tle.SetCellValue(evaluateTable.Reject[0].Title);
            cellReject2Ti1tle.CellStyle = normalCenterStyle;
            region = new CellRangeAddress(6 + (keyCount + evaluateTable.Response.Count + evaluateTable.Qualify.Count + evaluateTable.Attitude.Count) * 2 + 1, 6 + (keyCount + evaluateTable.Response.Count + evaluateTable.Qualify.Count + evaluateTable.Attitude.Count) * 2 + 1, 2, 3);
            sheet.AddMergedRegion(region);
            ((HSSFSheet)sheet).SetEnclosedBorderOfRegion(region, BorderStyle.THIN, NPOI.HSSF.Util.HSSFColor.BLACK.index);

            ICell cellReject2Content = rowReject2.CreateCell(4);
            cellReject2Content.SetCellValue(evaluateTable.Reject[0].Content[0]);
            cellReject2Content.CellStyle = normalStyle;
            region = new CellRangeAddress(6 + (keyCount + evaluateTable.Response.Count + evaluateTable.Qualify.Count + evaluateTable.Attitude.Count) * 2 + 1, 6 + (keyCount + evaluateTable.Response.Count + evaluateTable.Qualify.Count + evaluateTable.Attitude.Count) * 2 + 1, 4, 6);
            sheet.AddMergedRegion(region);
            ((HSSFSheet)sheet).SetEnclosedBorderOfRegion(region, BorderStyle.THIN, NPOI.HSSF.Util.HSSFColor.BLACK.index);

            //合并得分栏
            for (int i = 0; i < (keyCount + evaluateTable.Response.Count + evaluateTable.Qualify.Count + evaluateTable.Attitude.Count + 1); i++)
            {
                region = new CellRangeAddress(6 + i * 2, 6 + i * 2 + 1, 8, 8);
                sheet.AddMergedRegion(region); ((HSSFSheet)sheet).SetEnclosedBorderOfRegion(region, BorderStyle.THIN, NPOI.HSSF.Util.HSSFColor.BLACK.index);
            }

            //合并权重栏
            IRow rowWeight1 = sheet.GetRow(6);
            ICell cellWeight1 = rowWeight1.CreateCell(10);
            cellWeight1.SetCellValue("50%");
            cellWeight1.CellStyle = normalCenterStyle;
            region = new CellRangeAddress(6, 6 + keyCount * 2 - 1, 10, 10);
            sheet.AddMergedRegion(region);
            ((HSSFSheet)sheet).SetEnclosedBorderOfRegion(region, BorderStyle.THIN, NPOI.HSSF.Util.HSSFColor.BLACK.index);
            region = new CellRangeAddress(6, 6 + keyCount * 2 - 1, 11, 11);
            sheet.AddMergedRegion(region);
            ((HSSFSheet)sheet).SetEnclosedBorderOfRegion(region, BorderStyle.THIN, NPOI.HSSF.Util.HSSFColor.BLACK.index);
            region = new CellRangeAddress(6, 6 + keyCount * 2 - 1, 9, 9);
            sheet.AddMergedRegion(region);
            ((HSSFSheet)sheet).SetEnclosedBorderOfRegion(region, BorderStyle.THIN, NPOI.HSSF.Util.HSSFColor.BLACK.index);


            IRow rowWeight2 = sheet.GetRow(6 + keyCount * 2);
            ICell cellWeight2 = rowWeight2.CreateCell(10);
            cellWeight2.SetCellValue("20%");
            cellWeight2.CellStyle = normalCenterStyle;
            region = new CellRangeAddress(6 + keyCount * 2, 6 + (keyCount + evaluateTable.Response.Count) * 2 - 1, 10, 10);
            sheet.AddMergedRegion(region);
            ((HSSFSheet)sheet).SetEnclosedBorderOfRegion(region, BorderStyle.THIN, NPOI.HSSF.Util.HSSFColor.BLACK.index);
            region = new CellRangeAddress(6 + keyCount * 2, 6 + (keyCount + evaluateTable.Response.Count) * 2 - 1, 11, 11);
            sheet.AddMergedRegion(region);
            ((HSSFSheet)sheet).SetEnclosedBorderOfRegion(region, BorderStyle.THIN, NPOI.HSSF.Util.HSSFColor.BLACK.index);
            region = new CellRangeAddress(6 + keyCount * 2, 6 + (keyCount + evaluateTable.Response.Count) * 2 - 1, 9, 9);
            sheet.AddMergedRegion(region);
            ((HSSFSheet)sheet).SetEnclosedBorderOfRegion(region, BorderStyle.THIN, NPOI.HSSF.Util.HSSFColor.BLACK.index);


            IRow rowWeight3 = sheet.GetRow(6 + (keyCount + evaluateTable.Response.Count) * 2);
            ICell cellWeight3 = rowWeight3.CreateCell(10);
            cellWeight3.SetCellValue("15%");
            cellWeight3.CellStyle = normalCenterStyle;
            region = new CellRangeAddress(6 + (keyCount + evaluateTable.Response.Count) * 2, 6 + (keyCount + evaluateTable.Response.Count + evaluateTable.Qualify.Count) * 2 - 1, 10, 10);
            sheet.AddMergedRegion(region);
            ((HSSFSheet)sheet).SetEnclosedBorderOfRegion(region, BorderStyle.THIN, NPOI.HSSF.Util.HSSFColor.BLACK.index);
            region = new CellRangeAddress(6 + (keyCount + evaluateTable.Response.Count) * 2, 6 + (keyCount + evaluateTable.Response.Count + evaluateTable.Qualify.Count) * 2 - 1, 11, 11);
            sheet.AddMergedRegion(region);
            ((HSSFSheet)sheet).SetEnclosedBorderOfRegion(region, BorderStyle.THIN, NPOI.HSSF.Util.HSSFColor.BLACK.index);
            region = new CellRangeAddress(6 + (keyCount + evaluateTable.Response.Count) * 2, 6 + (keyCount + evaluateTable.Response.Count + evaluateTable.Qualify.Count) * 2 - 1, 9, 9);
            sheet.AddMergedRegion(region);
            ((HSSFSheet)sheet).SetEnclosedBorderOfRegion(region, BorderStyle.THIN, NPOI.HSSF.Util.HSSFColor.BLACK.index);


            IRow rowWeight4 = sheet.GetRow(6 + (keyCount + evaluateTable.Response.Count + evaluateTable.Qualify.Count) * 2);
            ICell cellWeight4 = rowWeight4.CreateCell(10);
            cellWeight4.SetCellValue("15%");
            cellWeight4.CellStyle = normalCenterStyle;
            region = new CellRangeAddress(6 + (keyCount + evaluateTable.Response.Count + evaluateTable.Qualify.Count) * 2, 6 + (keyCount + evaluateTable.Response.Count + evaluateTable.Qualify.Count + evaluateTable.Attitude.Count) * 2 - 1, 10, 10);
            sheet.AddMergedRegion(region);
            ((HSSFSheet)sheet).SetEnclosedBorderOfRegion(region, BorderStyle.THIN, NPOI.HSSF.Util.HSSFColor.BLACK.index);
            region = new CellRangeAddress(6 + (keyCount + evaluateTable.Response.Count + evaluateTable.Qualify.Count) * 2, 6 + (keyCount + evaluateTable.Response.Count + evaluateTable.Qualify.Count + evaluateTable.Attitude.Count) * 2 - 1, 11, 11);
            sheet.AddMergedRegion(region);
            ((HSSFSheet)sheet).SetEnclosedBorderOfRegion(region, BorderStyle.THIN, NPOI.HSSF.Util.HSSFColor.BLACK.index);
            region = new CellRangeAddress(6 + (keyCount + evaluateTable.Response.Count + evaluateTable.Qualify.Count) * 2, 6 + (keyCount + evaluateTable.Response.Count + evaluateTable.Qualify.Count + evaluateTable.Attitude.Count) * 2 - 1, 9, 9);
            sheet.AddMergedRegion(region);
            ((HSSFSheet)sheet).SetEnclosedBorderOfRegion(region, BorderStyle.THIN, NPOI.HSSF.Util.HSSFColor.BLACK.index);


            IRow rowWeight5 = sheet.GetRow(6 + (keyCount + evaluateTable.Response.Count + evaluateTable.Qualify.Count + evaluateTable.Attitude.Count) * 2);
            ICell cellWeight5 = rowWeight5.CreateCell(10);
            cellWeight5.SetCellValue("100%");
            cellWeight5.CellStyle = normalCenterStyle;
            region = new CellRangeAddress(6 + (keyCount + evaluateTable.Response.Count + evaluateTable.Qualify.Count + evaluateTable.Attitude.Count) * 2, 6 + (keyCount + evaluateTable.Response.Count + evaluateTable.Qualify.Count + evaluateTable.Attitude.Count) * 2 + 1, 10, 10);
            sheet.AddMergedRegion(region);
            ((HSSFSheet)sheet).SetEnclosedBorderOfRegion(region, BorderStyle.THIN, NPOI.HSSF.Util.HSSFColor.BLACK.index);
            region = new CellRangeAddress(6 + (keyCount + evaluateTable.Response.Count + evaluateTable.Qualify.Count + evaluateTable.Attitude.Count) * 2, 6 + (keyCount + evaluateTable.Response.Count + evaluateTable.Qualify.Count + evaluateTable.Attitude.Count) * 2 + 1, 11, 11);
            sheet.AddMergedRegion(region);
            ((HSSFSheet)sheet).SetEnclosedBorderOfRegion(region, BorderStyle.THIN, NPOI.HSSF.Util.HSSFColor.BLACK.index);
            region = new CellRangeAddress(6 + (keyCount + evaluateTable.Response.Count + evaluateTable.Qualify.Count + evaluateTable.Attitude.Count) * 2, 6 + (keyCount + evaluateTable.Response.Count + evaluateTable.Qualify.Count + evaluateTable.Attitude.Count) * 2 + 1, 9, 9);
            sheet.AddMergedRegion(region);
            ((HSSFSheet)sheet).SetEnclosedBorderOfRegion(region, BorderStyle.THIN, NPOI.HSSF.Util.HSSFColor.BLACK.index);

            //合计行
            IRow rowSum = sheet.CreateRow(6 + (keyCount + evaluateTable.Response.Count + evaluateTable.Qualify.Count + evaluateTable.Attitude.Count) * 2 + 2);
            ICell cellSum = rowSum.CreateCell(0);
            cellSum.SetCellValue("合计");
            cellSum.CellStyle = normalCenterStyle;
            region = new CellRangeAddress(6 + (keyCount + evaluateTable.Response.Count + evaluateTable.Qualify.Count + evaluateTable.Attitude.Count) * 2 + 2, 6 + (keyCount + evaluateTable.Response.Count + evaluateTable.Qualify.Count + evaluateTable.Attitude.Count) * 2 + 2, 0, 3);
            sheet.AddMergedRegion(region);
            ((HSSFSheet)sheet).SetEnclosedBorderOfRegion(region, BorderStyle.THIN, NPOI.HSSF.Util.HSSFColor.BLACK.index);

            region = new CellRangeAddress(6 + (keyCount + evaluateTable.Response.Count + evaluateTable.Qualify.Count + evaluateTable.Attitude.Count) * 2 + 2, 6 + (keyCount + evaluateTable.Response.Count + evaluateTable.Qualify.Count + evaluateTable.Attitude.Count) * 2 + 2, 4, 11);
            sheet.AddMergedRegion(region);
            ((HSSFSheet)sheet).SetEnclosedBorderOfRegion(region, BorderStyle.THIN, NPOI.HSSF.Util.HSSFColor.BLACK.index);

            //表注脚
            IRow rowFoot1 = sheet.CreateRow(6 + (keyCount + evaluateTable.Response.Count + evaluateTable.Qualify.Count + evaluateTable.Attitude.Count) * 2 + 3);
            ICell cellFoot1 = rowFoot1.CreateCell(0);
            cellFoot1.SetCellValue("注：被考核者在否决指标中有其中一项情况的，则该指标计为-10分。否决指标为合格的计为0分。");
            cellFoot1.CellStyle = normalStyleNoBorder;
            region = new CellRangeAddress(6 + (keyCount + evaluateTable.Response.Count + evaluateTable.Qualify.Count + evaluateTable.Attitude.Count) * 2 + 3, 6 + (keyCount + evaluateTable.Response.Count + evaluateTable.Qualify.Count + evaluateTable.Attitude.Count) * 2 + 3, 0, 11);
            sheet.AddMergedRegion(region);

            IRow rowFoot2 = sheet.CreateRow(6 + (keyCount + evaluateTable.Response.Count + evaluateTable.Qualify.Count + evaluateTable.Attitude.Count) * 2 + 4);
            ICell cellFoot2 = rowFoot2.CreateCell(0);
            cellFoot2.SetCellValue("计分人签名：");
            cellFoot2.CellStyle = normalStyleNoBorder;
            region = new CellRangeAddress(6 + (keyCount + evaluateTable.Response.Count + evaluateTable.Qualify.Count + evaluateTable.Attitude.Count) * 2 + 4, 6 + (keyCount + evaluateTable.Response.Count + evaluateTable.Qualify.Count + evaluateTable.Attitude.Count) * 2 + 4, 0, 3);
            sheet.AddMergedRegion(region);

            ICell cellFoot3 = rowFoot2.CreateCell(4);
            cellFoot3.SetCellValue("审核人签名：");
            cellFoot3.CellStyle = normalStyleNoBorder;
            region = new CellRangeAddress(6 + (keyCount + evaluateTable.Response.Count + evaluateTable.Qualify.Count + evaluateTable.Attitude.Count) * 2 + 4, 6 + (keyCount + evaluateTable.Response.Count + evaluateTable.Qualify.Count + evaluateTable.Attitude.Count) * 2 + 4, 4, 11);
            sheet.AddMergedRegion(region);

            IRow rowFoot3 = sheet.CreateRow(6 + (keyCount + evaluateTable.Response.Count + evaluateTable.Qualify.Count + evaluateTable.Attitude.Count) * 2 + 5);
            ICell cellFoot4 = rowFoot3.CreateCell(0);
            cellFoot4.SetCellValue("日期：    年  月  日");
            cellFoot4.CellStyle = normalStyleNoBorder;
            region = new CellRangeAddress(6 + (keyCount + evaluateTable.Response.Count + evaluateTable.Qualify.Count + evaluateTable.Attitude.Count) * 2 + 5, 6 + (keyCount + evaluateTable.Response.Count + evaluateTable.Qualify.Count + evaluateTable.Attitude.Count) * 2 + 5, 0, 3);
            sheet.AddMergedRegion(region);

            ICell cellFoot5 = rowFoot3.CreateCell(4);
            cellFoot5.SetCellValue("日期：    年  月  日");
            cellFoot5.CellStyle = normalStyleNoBorder;
            region = new CellRangeAddress(6 + (keyCount + evaluateTable.Response.Count + evaluateTable.Qualify.Count + evaluateTable.Attitude.Count) * 2 + 5, 6 + (keyCount + evaluateTable.Response.Count + evaluateTable.Qualify.Count + evaluateTable.Attitude.Count) * 2 + 5, 4, 11);
            sheet.AddMergedRegion(region);

            if (writeToFile(hssfworkbook, evaluateTable.EvaluatedName, ref fileName))
            {
                return true;
            }
            else
            {
                exception = "创建文件失败！";
                return false;
            }
        }

        /// <summary>
        /// 导出指定的岗位责任书到word，导出成功返回true，否则返回false
        /// </summary>
        /// <param name="fileName">生成文件的文件名</param>
        /// <param name="postBook">岗位责任书</param>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool ExportPostBook(ref string fileName, string evaluatedName, PostBook postBook, ref string exception)
        {
            fileName = DateTime.Now.ToString("yyyy-mm-dd-HH-mm-ss") + evaluatedName + @"的岗位责任书.doc";
            object path = System.AppDomain.CurrentDomain.BaseDirectory.ToString() + @"downloadfiles\" + fileName;
            string strContent = "";
            object nothing = Missing.Value;
            MSWord.Application wordApp = new MSWord.Application();
            MSWord.Document wordDoc = wordApp.Documents.Add(ref nothing, ref nothing, ref nothing, ref nothing);
            wordApp.Selection.ParagraphFormat.LineSpacing = 16;

            writeParagraph(ref wordDoc, "岗位责任书", "宋体", 1, 18, MSWord.WdParagraphAlignment.wdAlignParagraphCenter);
            writeParagraph(ref wordDoc, "一、岗位概述", "黑体", 1, 11, MSWord.WdParagraphAlignment.wdAlignParagraphLeft);
            strContent = "\t1、用人单位：\t" + postBook.Employer + "\n"
                            + "\t2、用工单位：\t同济大学" + postBook.LaborDepart + "\n"
                            + "\t3、用工部门：" + "\t" + postBook.LaborUnit + "\n"
                            + "\t4、岗位名称：" + "\t" + postBook.PostName;
            writeParagraph(ref wordDoc, strContent, "宋体", 0, 11, MSWord.WdParagraphAlignment.wdAlignParagraphLeft);
            switch (postBook.PostType)
            {
                case "管理":
                    strContent = "\t5、岗位类别：\t■管理 □教辅 □思政 □教师 □工勤";
                    break;
                case "教辅":
                    strContent = "\t5、岗位类别：\t□管理 ■教辅 □思政 □教师 □工勤";
                    break;
                case "思政":
                    strContent = "\t5、岗位类别：\t□管理 □教辅 ■思政 □教师 □工勤";
                    break;
                case "教师":
                    strContent = "\t5、岗位类别：\t□管理 □教辅 □思政 ■教师 □工勤";
                    break;
                case "工勤":
                    strContent = "\t5、岗位类别：□管理 □教辅 □思政 □教师 ■工勤";
                    break;
            }
            writeParagraph(ref wordDoc, strContent, "宋体", 0, 11, MSWord.WdParagraphAlignment.wdAlignParagraphLeft);

            writeParagraph(ref wordDoc, "二、岗位职责", "黑体", 1, 11, MSWord.WdParagraphAlignment.wdAlignParagraphLeft);

            writeParagraph(ref wordDoc, "（一）任职条件", "宋体", 1, 11, MSWord.WdParagraphAlignment.wdAlignParagraphLeft);

            strContent = "1、学历背景：";
            writeParagraph(ref wordDoc, strContent, "宋体", 1, 11, MSWord.WdParagraphAlignment.wdAlignParagraphLeft);
            strContent = postBook.EduBg;
            writeParagraph(ref wordDoc, strContent, "宋体", 0, 11, MSWord.WdParagraphAlignment.wdAlignParagraphLeft);

            strContent = "2、培训及资历：";
            writeParagraph(ref wordDoc, strContent, "宋体", 1, 11, MSWord.WdParagraphAlignment.wdAlignParagraphLeft);
            strContent = postBook.Certificate;
            writeParagraph(ref wordDoc, strContent, "宋体", 0, 11, MSWord.WdParagraphAlignment.wdAlignParagraphLeft);

            strContent = "3、工作经验：";
            writeParagraph(ref wordDoc, strContent, "宋体", 1, 11, MSWord.WdParagraphAlignment.wdAlignParagraphLeft);
            strContent = postBook.Experience;
            writeParagraph(ref wordDoc, strContent, "宋体", 0, 11, MSWord.WdParagraphAlignment.wdAlignParagraphLeft);

            strContent = "4、基本技能和素质：";
            writeParagraph(ref wordDoc, strContent, "宋体", 1, 11, MSWord.WdParagraphAlignment.wdAlignParagraphLeft);
            strContent = postBook.Skill;
            writeParagraph(ref wordDoc, strContent, "宋体", 0, 11, MSWord.WdParagraphAlignment.wdAlignParagraphLeft);

            strContent = "5、特性特征：";
            writeParagraph(ref wordDoc, strContent, "宋体", 1, 11, MSWord.WdParagraphAlignment.wdAlignParagraphLeft);
            strContent = postBook.Personality;
            writeParagraph(ref wordDoc, strContent, "宋体", 0, 11, MSWord.WdParagraphAlignment.wdAlignParagraphLeft);

            strContent = "6、体质条件：";
            writeParagraph(ref wordDoc, strContent, "宋体", 1, 11, MSWord.WdParagraphAlignment.wdAlignParagraphLeft);
            strContent = postBook.PhyCond;
            writeParagraph(ref wordDoc, strContent, "宋体", 0, 11, MSWord.WdParagraphAlignment.wdAlignParagraphLeft);

            writeParagraph(ref wordDoc, "（二）工作内容、工作要求", "宋体", 1, 11, MSWord.WdParagraphAlignment.wdAlignParagraphLeft);

            strContent = "1、岗位概述：";
            writeParagraph(ref wordDoc, strContent, "宋体", 1, 11, MSWord.WdParagraphAlignment.wdAlignParagraphLeft);
            strContent = postBook.WorkOutline;
            writeParagraph(ref wordDoc, strContent, "宋体", 0, 11, MSWord.WdParagraphAlignment.wdAlignParagraphLeft);

            strContent = "2、工作内容及工作要求：";
            writeParagraph(ref wordDoc, strContent, "宋体", 1, 11, MSWord.WdParagraphAlignment.wdAlignParagraphLeft);
            for (int i = 1; i < postBook.WorkContentRequest.Count; i++)
            {
                strContent = "\t" + i + ")" + postBook.WorkContentRequest[i - 1][0];
                writeParagraph(ref wordDoc, strContent, "宋体", 0, 11, MSWord.WdParagraphAlignment.wdAlignParagraphLeft);
                strContent = "\t具体内容：" + postBook.WorkContentRequest[i - 1][0];
                writeParagraph(ref wordDoc, strContent, "宋体", 0, 11, MSWord.WdParagraphAlignment.wdAlignParagraphLeft);
                strContent = "\t具体要求：" + postBook.WorkContentRequest[i - 1][0];
                writeParagraph(ref wordDoc, strContent, "宋体", 0, 11, MSWord.WdParagraphAlignment.wdAlignParagraphLeft);
                strContent = "\t考核要点：" + postBook.WorkContentRequest[i - 1][0];
                writeParagraph(ref wordDoc, strContent, "宋体", 0, 11, MSWord.WdParagraphAlignment.wdAlignParagraphLeft);
            }
            writeParagraph(ref wordDoc, strContent, "宋体", 0, 11, MSWord.WdParagraphAlignment.wdAlignParagraphLeft);

            writeParagraph(ref wordDoc, "（三）权责范围", "宋体", 1, 11, MSWord.WdParagraphAlignment.wdAlignParagraphLeft);

            strContent = "1、权利：";
            writeParagraph(ref wordDoc, strContent, "宋体", 1, 11, MSWord.WdParagraphAlignment.wdAlignParagraphLeft);
            strContent = postBook.Power;
            writeParagraph(ref wordDoc, strContent, "宋体", 0, 11, MSWord.WdParagraphAlignment.wdAlignParagraphLeft);

            strContent = "2、责任：";
            writeParagraph(ref wordDoc, strContent, "宋体", 1, 11, MSWord.WdParagraphAlignment.wdAlignParagraphLeft);
            strContent = postBook.Response;
            writeParagraph(ref wordDoc, strContent, "宋体", 0, 11, MSWord.WdParagraphAlignment.wdAlignParagraphLeft);

            writeParagraph(ref wordDoc, "（四）工作关系", "宋体", 1, 11, MSWord.WdParagraphAlignment.wdAlignParagraphLeft);

            strContent = "1、直接领导：" + postBook.DirectLeader;
            writeParagraph(ref wordDoc, strContent, "宋体", 0, 11, MSWord.WdParagraphAlignment.wdAlignParagraphLeft);

            strContent = "2、下属：" + postBook.Subordinate;
            writeParagraph(ref wordDoc, strContent, "宋体", 0, 11, MSWord.WdParagraphAlignment.wdAlignParagraphLeft);

            strContent = "3、同事：" + postBook.Colleague;
            writeParagraph(ref wordDoc, strContent, "宋体", 0, 11, MSWord.WdParagraphAlignment.wdAlignParagraphLeft);

            strContent = "4、服务对象：" + postBook.Services;
            writeParagraph(ref wordDoc, strContent, "宋体", 0, 11, MSWord.WdParagraphAlignment.wdAlignParagraphLeft);

            strContent = "5、外部关系：" + postBook.Relations;
            writeParagraph(ref wordDoc, strContent, "宋体", 0, 11, MSWord.WdParagraphAlignment.wdAlignParagraphLeft);

            writeParagraph(ref wordDoc, "（五）工作环境", "宋体", 1, 11, MSWord.WdParagraphAlignment.wdAlignParagraphLeft);

            strContent = postBook.WorkEnter;
            writeParagraph(ref wordDoc, strContent, "宋体", 0, 11, MSWord.WdParagraphAlignment.wdAlignParagraphLeft);

            writeParagraph(ref wordDoc, "三、岗位考核", "黑体", 1, 11, MSWord.WdParagraphAlignment.wdAlignParagraphLeft);

            strContent = postBook.PostAssess;
            writeParagraph(ref wordDoc, strContent, "宋体", 0, 11, MSWord.WdParagraphAlignment.wdAlignParagraphLeft);

            writeParagraph(ref wordDoc, "四、其他规定", "黑体", 1, 11, MSWord.WdParagraphAlignment.wdAlignParagraphLeft);

            strContent = postBook.Others;
            writeParagraph(ref wordDoc, strContent, "宋体", 0, 11, MSWord.WdParagraphAlignment.wdAlignParagraphLeft);

            writeParagraph(ref wordDoc, "", "宋体", 0, 11, MSWord.WdParagraphAlignment.wdAlignParagraphLeft);
            writeParagraph(ref wordDoc, "", "宋体", 0, 11, MSWord.WdParagraphAlignment.wdAlignParagraphLeft);
            writeParagraph(ref wordDoc, "", "宋体", 0, 11, MSWord.WdParagraphAlignment.wdAlignParagraphLeft);

            strContent = "部门负责人签章：\t\t\t\t个人签字：\n" +
                         "\t\t\t\t\t\t\t\t身份证号码：\n" +
                         "\t\t\t\t\t\t\t\t联系电话（固定电话）：\n" +
                         "\t\t\t\t\t\t\t\t联系电话（移动电话）：\n" +
                         "\t\t\t\t\t\t\t\t联系地址：\n" +
                         "\t\t\t\t\t\t\t\t邮编：\n" +
                         "日期：    年    月    日\t\t日期：    年    月    日";

            writeParagraph(ref wordDoc, strContent, "宋体", 0, 11, MSWord.WdParagraphAlignment.wdAlignParagraphLeft);

            try
            {
                object format = MSWord.WdSaveFormat.wdFormatDocument97;
                wordDoc.SaveAs(ref path, ref format, ref nothing, ref nothing, ref nothing, ref nothing, ref nothing, ref nothing, ref nothing, ref nothing, ref nothing, ref nothing, ref nothing, ref nothing, ref nothing, ref nothing);
                wordDoc.Close(ref nothing, ref nothing, ref nothing);
                wordApp.Quit(ref nothing, ref nothing, ref nothing);
                wordDoc = null;
                wordApp = null;

                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                GC.WaitForPendingFinalizers();
                return true;
            }
            catch (Exception)
            {
                exception = "写文件失败！";
                return false;
            }
        }

        /// <summary>
        /// 导出指定的个人考核结果
        /// </summary>
        /// <param name="fileName">导出结果的文件名</param>
        /// <param name="evaluatedName">被考评人姓名</param>
        /// <param name="evaluationResult">考核结果</param>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool ExportEvaluationResultForIndividual(ref string fileName, string evaluatedName, EvaluationResult evaluationResult, ref string exception)
        {
            string sourceFilePath = "";
            int itemCount = 0;
            if (evaluationResult.Is360)
            {
                sourceFilePath = System.AppDomain.CurrentDomain.BaseDirectory.ToString() + @"downloadfiles\template\360度考核模板.xls";
                itemCount = 5;
            }
            else
            {
                sourceFilePath = System.AppDomain.CurrentDomain.BaseDirectory.ToString() + @"downloadfiles\template\270度考核模板.xls";
                itemCount = 4;
            }
            FileStream file = new FileStream(sourceFilePath, FileMode.Open, FileAccess.Read);

            HSSFWorkbook hssfworkbook = new HSSFWorkbook(file);

            //create a entry of DocumentSummaryInformation
            DocumentSummaryInformation dsi = PropertySetFactory.CreateDocumentSummaryInformation();
            dsi.Company = "NPOI Team";
            hssfworkbook.DocumentSummaryInformation = dsi;

            //create a entry of SummaryInformation
            SummaryInformation si = PropertySetFactory.CreateSummaryInformation();
            si.Subject = "NPOI SDK Example";
            hssfworkbook.SummaryInformation = si;

            ISheet sheet1 = hssfworkbook.GetSheet("Sheet1");
            sheet1.GetRow(1).GetCell(0).SetCellValue("被考核人姓名：" + evaluatedName);
            sheet1.GetRow(1).GetCell(1).SetCellValue("岗位名称：" + evaluationResult.PostName);
            sheet1.GetRow(1).GetCell(2).SetCellValue("用工部门：" + evaluationResult.LaborDep);
            sheet1.GetRow(1).GetCell(3).SetCellValue("用工单位：同济大学" + evaluationResult.LaborUnit);
            sheet1.GetRow(2).GetCell(0).SetCellValue("考核时间段：" + evaluationResult.StartTime + " ~ " + evaluationResult.StopTime);
            sheet1.GetRow(2).GetCell(3).SetCellValue("考核日期：");

            for (int i = 0; i < itemCount; i++)
            {
                sheet1.GetRow(4).GetCell(i + 1).SetCellValue(evaluationResult.KeyScore[i]);
            }

            for (int i = 0; i < itemCount; i++)
            {
                sheet1.GetRow(5).GetCell(i + 1).SetCellValue(evaluationResult.ResponseScore[i]);
            }

            for (int i = 0; i < itemCount; i++)
            {
                sheet1.GetRow(6).GetCell(i + 1).SetCellValue(evaluationResult.QualifyScore[i]);
            }

            for (int i = 0; i < itemCount; i++)
            {
                sheet1.GetRow(7).GetCell(i + 1).SetCellValue(evaluationResult.AttitudeScore[i]);
            }

            for (int i = 0; i < itemCount; i++)
            {
                sheet1.GetRow(8).GetCell(i + 1).SetCellValue(evaluationResult.RejectScore[i]);
            }

            for (int i = 0; i < itemCount; i++)
            {
                sheet1.GetRow(9).GetCell(i + 1).SetCellValue(evaluationResult.ResultScore[i]);
            }

            for (int i = 0; i < itemCount; i++)
            {
                sheet1.GetRow(10).GetCell(i + 1).SetCellValue(evaluationResult.EvaluatorNum[i]);
            }

            string evaluationLevel = "";
            switch (evaluationResult.EvaluationLevel)
            {
                case DepartEvaluationLevel.good:
                    evaluationLevel = "优秀(91~100)";
                    break;
                case DepartEvaluationLevel.notbad:
                    evaluationLevel = "良好(71~90)";
                    break;
                case DepartEvaluationLevel.qualified:
                    evaluationLevel = "合格(41~70)";
                    break;
                case DepartEvaluationLevel.unqualified:
                    evaluationLevel = "不合格(0~40)";
                    break;
                default:
                    break;
            }

            sheet1.GetRow(11).GetCell(1).SetCellValue(evaluationLevel);

            fileName = DateTime.Now.ToString("yyyy-mm-dd-HH-mm-ss") + evaluatedName + @"的考核结果.xls";
            string path = System.AppDomain.CurrentDomain.BaseDirectory.ToString() + @"downloadfiles\\" + fileName;
            FileStream fileWrite = new FileStream(path, FileMode.Create);
            try
            {
                hssfworkbook.Write(fileWrite);
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                fileWrite.Close();
            }
            return true;
        }

        /// <summary>
        /// 导出指定部门的考核结果汇总表
        /// </summary>
        /// <param name="fileName">导出结果的文件名</param>
        /// <param name="depart">部门</param>
        /// <param name="table">包含结果的表</param>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool ExportEvaluationResultForDepart(ref string fileName, string depart, System.Data.DataTable table, string startTime, string stopTime, string evaluationDate, ref string exception)
        {
            HSSFWorkbook hssfworkbook = new HSSFWorkbook();
            ISheet sheet = hssfworkbook.CreateSheet("单位考核汇总表");

            CellRangeAddress region;


            //设置宽度
            sheet.SetColumnWidth(0, 6 * 256);
            sheet.SetColumnWidth(1, 16 * 256);
            sheet.SetColumnWidth(2, 20 * 256);
            sheet.SetColumnWidth(3, 19 * 256);
            sheet.SetColumnWidth(4, 22 * 256);
            sheet.SetColumnWidth(5, 23 * 256);

            //设置格式
            ICellStyle titleStyle = hssfworkbook.CreateCellStyle();
            titleStyle.Alignment = HorizontalAlignment.CENTER;
            titleStyle.VerticalAlignment = VerticalAlignment.CENTER;
            IFont titleFont = hssfworkbook.CreateFont();
            titleFont.FontName = "宋体";
            titleFont.FontHeightInPoints = 16;
            titleFont.Boldweight = (short)FontBoldWeight.BOLD;
            titleStyle.SetFont(titleFont);

            ICellStyle normalBoldLeftStyle = hssfworkbook.CreateCellStyle();
            normalBoldLeftStyle.Alignment = HorizontalAlignment.LEFT;
            normalBoldLeftStyle.VerticalAlignment = VerticalAlignment.CENTER;
            IFont normalBoldLeftFont = hssfworkbook.CreateFont();
            normalBoldLeftFont.FontName = "宋体";
            normalBoldLeftFont.FontHeightInPoints = 11;
            normalBoldLeftFont.Boldweight = (short)FontBoldWeight.BOLD;
            normalBoldLeftStyle.SetFont(normalBoldLeftFont);
            normalBoldLeftStyle.WrapText = false;

            ICellStyle normalBoldCenterStyle = hssfworkbook.CreateCellStyle();
            normalBoldCenterStyle.Alignment = HorizontalAlignment.CENTER;
            normalBoldCenterStyle.VerticalAlignment = VerticalAlignment.CENTER;
            IFont normalBoldCenterFont = hssfworkbook.CreateFont();
            normalBoldCenterFont.FontName = "宋体";
            normalBoldCenterFont.FontHeightInPoints = 11;
            normalBoldCenterFont.Boldweight = (short)FontBoldWeight.BOLD;
            normalBoldCenterStyle.SetFont(normalBoldCenterFont);
            normalBoldCenterStyle.WrapText = false;
            normalBoldCenterStyle.BorderTop = BorderStyle.THIN;
            normalBoldCenterStyle.BorderBottom = BorderStyle.THIN;
            normalBoldCenterStyle.BorderLeft = BorderStyle.THIN;
            normalBoldCenterStyle.BorderRight = BorderStyle.THIN;

            ICellStyle normalCenterStyle = hssfworkbook.CreateCellStyle();
            normalCenterStyle.Alignment = HorizontalAlignment.CENTER;
            normalCenterStyle.VerticalAlignment = VerticalAlignment.CENTER;
            IFont normalCenterFont = hssfworkbook.CreateFont();
            normalCenterFont.FontName = "宋体";
            normalCenterFont.FontHeightInPoints = 11;
            normalCenterStyle.SetFont(normalCenterFont);
            normalCenterStyle.WrapText = false;
            normalCenterStyle.BorderTop = BorderStyle.THIN;
            normalCenterStyle.BorderBottom = BorderStyle.THIN;
            normalCenterStyle.BorderLeft = BorderStyle.THIN;
            normalCenterStyle.BorderRight = BorderStyle.THIN;

            ICellStyle normalLeftStyle = hssfworkbook.CreateCellStyle();
            normalLeftStyle.Alignment = HorizontalAlignment.LEFT;
            normalLeftStyle.VerticalAlignment = VerticalAlignment.CENTER;
            IFont normalLeftFont = hssfworkbook.CreateFont();
            normalLeftFont.FontName = "宋体";
            normalLeftFont.FontHeightInPoints = 11;
            normalLeftStyle.SetFont(normalLeftFont);
            normalLeftStyle.WrapText = false;

            //标题行
            IRow row0 = sheet.CreateRow(0);
            row0.HeightInPoints = 28;
            ICell cell00 = row0.CreateCell(0);
            cell00.SetCellValue("同济大学" + depart + "（单位）派遣人员考核汇总表");
            cell00.CellStyle = titleStyle;
            region = new CellRangeAddress(0, 0, 0, 5);
            sheet.AddMergedRegion(region);

            //表头第一行:考核时间段
            IRow row1 = sheet.CreateRow(1);
            row1.HeightInPoints = 29;
            ICell cell10 = row1.CreateCell(0);
            cell10.SetCellValue("考核时间段：" + startTime + "至" + stopTime);
            cell10.CellStyle = normalBoldLeftStyle;
            region = new CellRangeAddress(1, 1, 0, 3);
            sheet.AddMergedRegion(region);

            //表头第一行:考核日期
            row1.HeightInPoints = 29;
            ICell cell11 = row1.CreateCell(4);
            cell11.SetCellValue("考核日期：" + evaluationDate);
            cell11.CellStyle = normalBoldLeftStyle;
            region = new CellRangeAddress(1, 1, 4, 5);
            sheet.AddMergedRegion(region);

            //表标题行
            IRow row2 = sheet.CreateRow(2);
            row2.HeightInPoints = 29;
            ICell cell20 = row2.CreateCell(0);
            cell20.SetCellValue("序号");
            cell20.CellStyle = normalBoldCenterStyle;
            ICell cell21 = row2.CreateCell(1);
            cell21.SetCellValue("姓名");
            cell21.CellStyle = normalBoldCenterStyle;
            ICell cell22 = row2.CreateCell(2);
            cell22.SetCellValue("考核得分");
            cell22.CellStyle = normalBoldCenterStyle;
            ICell cell23 = row2.CreateCell(3);
            cell23.SetCellValue("考核结果");
            cell23.CellStyle = normalBoldCenterStyle;
            ICell cell24 = row2.CreateCell(4);
            cell24.SetCellValue("考核人数");
            cell24.CellStyle = normalBoldCenterStyle;
            ICell cell25 = row2.CreateCell(5);
            cell25.SetCellValue("备注");
            cell25.CellStyle = normalBoldCenterStyle;

            IRow rowScore;
            ICell cell0, cell1, cell2, cell3, cell4, cell5;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                rowScore = sheet.CreateRow(i + 3);
                rowScore.HeightInPoints = 29;
                cell0 = rowScore.CreateCell(0);
                cell0.SetCellValue(i + 1);
                cell0.CellStyle = normalCenterStyle;

                cell1 = rowScore.CreateCell(1);
                cell1.SetCellValue(table.Rows[i]["Name"].ToString());
                cell1.CellStyle = normalCenterStyle;

                cell2 = rowScore.CreateCell(2);
                cell2.SetCellValue(table.Rows[i]["Score"].ToString());
                cell2.CellStyle = normalCenterStyle;

                cell3 = rowScore.CreateCell(3);
                cell3.SetCellValue(table.Rows[i]["Result"].ToString());
                cell3.CellStyle = normalCenterStyle;

                cell4 = rowScore.CreateCell(4);
                cell4.SetCellValue(table.Rows[i]["EvaluatorNum"].ToString());
                cell4.CellStyle = normalCenterStyle;

                cell5 = rowScore.CreateCell(5);
                cell5.SetCellValue(table.Rows[i]["Comment"].ToString());
                cell5.CellStyle = normalCenterStyle;
            }

            //表脚第一行
            IRow rowFoot1 = sheet.CreateRow(3 + table.Rows.Count);
            rowFoot1.HeightInPoints = 29;

            ICell cellFoot10 = rowFoot1.CreateCell(0);
            cellFoot10.SetCellValue("制表人签名：");
            cellFoot10.CellStyle = normalLeftStyle;
            region = new CellRangeAddress(3 + table.Rows.Count, 3 + table.Rows.Count, 0, 2);
            sheet.AddMergedRegion(region);
            
            ICell cellFoot11 = rowFoot1.CreateCell(3);
            cellFoot11.SetCellValue("用工单位领导签名（盖章）：");
            cellFoot11.CellStyle = normalLeftStyle;
            region = new CellRangeAddress(3 + table.Rows.Count, 3 + table.Rows.Count, 3, 5);
            sheet.AddMergedRegion(region);

            //表脚第二行
            IRow rowFoot2 = sheet.CreateRow(4 + table.Rows.Count);
            rowFoot2.HeightInPoints = 29;

            ICell cellFoot20 = rowFoot2.CreateCell(0);
            cellFoot20.SetCellValue("日期：");
            cellFoot20.CellStyle = normalLeftStyle;
            region = new CellRangeAddress(4 + table.Rows.Count, 4 + table.Rows.Count, 0, 2);
            sheet.AddMergedRegion(region);

            ICell cellFoot21 = rowFoot2.CreateCell(3);
            cellFoot21.SetCellValue("日期：");
            cellFoot21.CellStyle = normalLeftStyle;
            region = new CellRangeAddress(4 + table.Rows.Count, 4 + table.Rows.Count, 3, 5);
            sheet.AddMergedRegion(region);

            //写文件
            fileName = DateTime.Now.ToString("yyyy-mm-dd-HH-mm-ss") + depart + @"考核汇总表.xls";
            string path = System.AppDomain.CurrentDomain.BaseDirectory.ToString() + @"downloadfiles\\" + fileName;
            FileStream file = new FileStream(path, FileMode.Create);
            try
            {
                hssfworkbook.Write(file);
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                file.Close();
            }
            return true;
        }

        /// <summary>
        /// 将指定的Excel转换成pdf
        /// </summary>
        /// <param name="targetName">生成的pdf文件名</param>
        /// <param name="sourceName">源excel文件名</param>
        /// <param name="exception"></param>
        /// <returns>转换成功返回true，否则返回false</returns>
        public static bool ConvertExcelToPDF(ref string targetName, string sourceName, ref string exception)
        {
            bool result = false;
            MSExcel.XlFixedFormatType targetType = MSExcel.XlFixedFormatType.xlTypePDF;
            object missing = Type.Missing;
            MSExcel.Application application = null;
            MSExcel.Workbook workBook = null;
            try
            {
                application = new MSExcel.Application();
                targetName = sourceName.Replace(".xls", ".pdf");
                string targetPath = System.AppDomain.CurrentDomain.BaseDirectory.ToString() + @"downloadfiles\" + targetName;
                string sourcePath = System.AppDomain.CurrentDomain.BaseDirectory.ToString() + @"downloadfiles\" + sourceName;
                object target = targetPath;
                object type = targetType;
                workBook = application.Workbooks.Open(sourcePath, missing, missing, missing, missing, missing,
                        missing, missing, missing, missing, missing, missing, missing, missing, missing);

                workBook.ExportAsFixedFormat(targetType, target, MSExcel.XlFixedFormatQuality.xlQualityStandard, true, false, missing, missing, missing, missing);
                result = true;
            }
            catch (Exception e)
            {
                exception = e.Message;
                result = false;
            }
            finally
            {
                if (workBook != null)
                {
                    workBook.Close(true, missing, missing);
                    workBook = null;
                }
                if (application != null)
                {
                    application.Quit();
                    application = null;
                }
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
            return result;
        }

        //Word转换成pdf
        /// <summary>
        /// 把Word文件转换成为PDF格式文件
        /// </summary>
        /// <param name="sourcePath">源文件路径</param>
        /// <param name="targetPath">目标文件路径</param>
        /// <returns>true=转换成功</returns>
        public static bool ConvertWordToPDF(ref string targetName, string sourceName, ref string exception)
        {
            bool result = false;
            MSWord.WdExportFormat exportFormat = MSWord.WdExportFormat.wdExportFormatPDF;
            object paramMissing = Type.Missing;
            MSWord.Application wordApplication = new MSWord.Application();
            MSWord.Document wordDocument = null;
            try
            {
                targetName = sourceName.Replace(".doc", ".pdf");
                string targetPath = System.AppDomain.CurrentDomain.BaseDirectory.ToString() + @"downloadfiles\" + targetName;
                string sourcePath = System.AppDomain.CurrentDomain.BaseDirectory.ToString() + @"downloadfiles\" + sourceName;
                object paramSourceDocPath = sourcePath;
                string paramExportFilePath = targetPath;

                MSWord.WdExportFormat paramExportFormat = exportFormat;
                bool paramOpenAfterExport = false;
                MSWord.WdExportOptimizeFor paramExportOptimizeFor = MSWord.WdExportOptimizeFor.wdExportOptimizeForPrint;
                MSWord.WdExportRange paramExportRange = MSWord.WdExportRange.wdExportAllDocument;
                int paramStartPage = 0;
                int paramEndPage = 0;
                MSWord.WdExportItem paramExportItem = MSWord.WdExportItem.wdExportDocumentContent;
                bool paramIncludeDocProps = true;
                bool paramKeepIRM = true;
                MSWord.WdExportCreateBookmarks paramCreateBookmarks = MSWord.WdExportCreateBookmarks.wdExportCreateWordBookmarks;
                bool paramDocStructureTags = true;
                bool paramBitmapMissingFonts = true;
                bool paramUseISO19005_1 = false;

                wordDocument = wordApplication.Documents.Open(
                ref paramSourceDocPath, ref paramMissing, ref paramMissing,
                ref paramMissing, ref paramMissing, ref paramMissing,
                ref paramMissing, ref paramMissing, ref paramMissing,
                ref paramMissing, ref paramMissing, ref paramMissing,
                ref paramMissing, ref paramMissing, ref paramMissing,
                ref paramMissing);

                if (wordDocument != null)
                    wordDocument.ExportAsFixedFormat(paramExportFilePath,
                    paramExportFormat, paramOpenAfterExport,
                    paramExportOptimizeFor, paramExportRange, paramStartPage,
                    paramEndPage, paramExportItem, paramIncludeDocProps,
                    paramKeepIRM, paramCreateBookmarks, paramDocStructureTags,
                    paramBitmapMissingFonts, paramUseISO19005_1,
                    ref paramMissing);
                result = true;
            }
            catch(Exception e)
            {
                exception = e.Message;
                result = false;
            }
            finally
            {
                if (wordDocument != null)
                {
                    wordDocument.Close(ref paramMissing, ref paramMissing, ref paramMissing);
                    wordDocument = null;
                }
                if (wordApplication != null)
                {
                    wordApplication.Quit(ref paramMissing, ref paramMissing, ref paramMissing);
                    wordApplication = null;
                }
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
            return result;
        }
        #region Private Method
        /// <summary>
        /// 将workbook写到文件中，成功返回true，否则返回false
        /// </summary>
        /// <param name="hssfworkbook"></param>
        /// <param name="evaluatedName"></param>
        /// <param name="fileName"></param>
        /// <returns></returns>
        private static bool writeToFile(HSSFWorkbook hssfworkbook, string evaluatedName, ref string fileName)
        {
            fileName = DateTime.Now.ToString("yyyy-mm-dd-HH-mm-ss") + evaluatedName + @"的考核表.xls";
            string path = System.AppDomain.CurrentDomain.BaseDirectory.ToString() + @"downloadfiles\" + fileName;
            FileStream file = new FileStream(path, FileMode.Create);
            try
            {
                hssfworkbook.Write(file);
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                file.Close();
            }
            return true;
        }

        /// <summary>
        /// 生成分值行
        /// </summary>
        /// <param name="sheet"></param>
        /// <param name="rowIndex"></param>
        /// <param name="startColumn"></param>
        /// <param name="cellStyle"></param>
        private static void genScoreGradeRow(ISheet sheet, int rowIndex, int startColumn, ICellStyle cellStyle)
        {
            IRow row = sheet.GetRow(rowIndex);
            row.HeightInPoints = 16;
            ICell cell1 = row.CreateCell(startColumn);
            ICell cell2 = row.CreateCell(startColumn + 1);
            ICell cell3 = row.CreateCell(startColumn + 2);
            ICell cell4 = row.CreateCell(startColumn + 3);
            cell1.SetCellValue("优（91~100）");
            cell2.SetCellValue("良（71~90）");
            cell3.SetCellValue("中（41~70）");
            cell4.SetCellValue("差（0~40）");
            cell1.CellStyle = cellStyle;
            cell2.CellStyle = cellStyle;
            cell3.CellStyle = cellStyle;
            cell4.CellStyle = cellStyle;
        }

        /// <summary>
        /// 获取数组成员的最大长度
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        private static int getLongestContent(string[] content)
        {
            int returnValue = 0;
            foreach (string item in content)
            {
                if (item.Length > returnValue)
                {
                    returnValue = item.Length;
                }
            }
            return returnValue;
        }

        /// <summary>
        /// 根据格式向指定的文档中写段落
        /// </summary>
        /// <param name="wordDoc">指定的文档</param>
        /// <param name="strContent">内容</param>
        /// <param name="font">字体</param>
        /// <param name="bold">加黑</param>
        /// <param name="size">字号</param>
        /// <param name="align">对齐方式</param>
        private static void writeParagraph(ref MSWord.Document wordDoc, string strContent, string font, int bold, int size, MSWord.WdParagraphAlignment align)
        {
            wordDoc.Paragraphs.Add();
            wordDoc.Paragraphs.Last.Range.Font.Name = font;
            wordDoc.Paragraphs.Last.Range.Font.Bold = bold;
            wordDoc.Paragraphs.Last.Range.Font.Size = size;
            wordDoc.Paragraphs.Last.Alignment = align;
            wordDoc.Paragraphs.Last.Range.Text = strContent;
        }
        #endregion
    }
}
