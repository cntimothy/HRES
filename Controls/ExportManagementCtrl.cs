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

namespace Controls
{
    public static class ExportManagementCtrl
    {
        /// <summary>
        /// 导出指定的考评表到Excel，导出成功返回true，否则返回false
        /// </summary> 
        /// <param name="filename"></param>
        /// <param name="evaluateTable"></param>
        /// <param name="?"></param>
        /// <returns></returns>
        public static bool ExportEvaluateTable(ref string filename, EvaluateTable evaluateTable, ref string exception)
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
            normalBoldLeftStyle.BorderTop = BorderStyle.THIN;
            normalBoldLeftStyle.BorderBottom = BorderStyle.THIN;
            normalBoldLeftStyle.BorderLeft = BorderStyle.THIN;
            normalBoldLeftStyle.BorderRight = BorderStyle.THIN;

            ICellStyle normalBoldRightStyle = hssfworkbook.CreateCellStyle();
            normalBoldRightStyle.Alignment = HorizontalAlignment.RIGHT;
            normalBoldRightStyle.VerticalAlignment = VerticalAlignment.CENTER;
            IFont normalBoldRightFont = hssfworkbook.CreateFont();
            normalBoldRightFont.FontName = "宋体";
            normalBoldRightFont.FontHeightInPoints = 11;
            normalBoldRightFont.Boldweight = (short)FontBoldWeight.BOLD;
            normalBoldRightStyle.SetFont(normalBoldRightFont);
            normalBoldRightStyle.WrapText = true;
            normalBoldRightStyle.BorderTop = BorderStyle.THIN;
            normalBoldRightStyle.BorderBottom = BorderStyle.THIN;
            normalBoldRightStyle.BorderLeft = BorderStyle.THIN;
            normalBoldRightStyle.BorderRight = BorderStyle.THIN;

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
            cell00.CellStyle.BorderTop = BorderStyle.NONE;
            cell00.CellStyle.BorderBottom = BorderStyle.NONE;
            cell00.CellStyle.BorderLeft = BorderStyle.NONE;
            cell00.CellStyle.BorderRight = BorderStyle.NONE;
            region = new CellRangeAddress(0, 0, 0, 11);
            sheet.AddMergedRegion(region);

            //表头第一行
            IRow row1 = sheet.CreateRow(1);
            row1.HeightInPoints = 20;
            ICell cell10 = row1.CreateCell(0);
            cell10.SetCellValue("被考核人姓名：" + evaluateTable.EvaluatedName + "  岗位名称：" + evaluateTable.PostName + "  用工部门：" + evaluateTable.LaborDep + "  用工单位：同济大学" + evaluateTable.LaborUnit);
            cell10.CellStyle = normalBoldLeftStyle;
            cell10.CellStyle.BorderTop = BorderStyle.NONE;
            cell10.CellStyle.BorderBottom = BorderStyle.NONE;
            cell10.CellStyle.BorderLeft = BorderStyle.NONE;
            cell10.CellStyle.BorderRight = BorderStyle.NONE;
            region = new CellRangeAddress(1, 1, 0, 11);

            sheet.AddMergedRegion(region);

            //表头第二行
            IRow row2 = sheet.CreateRow(2);
            row2.HeightInPoints = 20;
            ICell cell20 = row2.CreateCell(0);
            cell20.SetCellValue("考核时间段：" + evaluateTable.StartTime + " ~ " + evaluateTable.StopTime + "  考核日期：      考评者类型：□领导；□同事；□下属；□服务对象");
            cell20.CellStyle = normalBoldLeftStyle;
            cell20.CellStyle.BorderTop = BorderStyle.NONE;
            cell20.CellStyle.BorderBottom = BorderStyle.NONE;
            cell20.CellStyle.BorderLeft = BorderStyle.NONE;
            cell20.CellStyle.BorderRight = BorderStyle.NONE;
            region = new CellRangeAddress(2, 2, 0, 11);
            sheet.AddMergedRegion(region);

            //表头第三行
            IRow row3 = sheet.CreateRow(3);
            row3.HeightInPoints = 20;
            ICell cell30 = row3.CreateCell(0);
            cell30.SetCellValue("经本人与所在用工单位协商一致，同意将以下考核指标作为对本人的年度考核依据。");
            cell30.CellStyle = normalBoldLeftStyle;
            cell30.CellStyle.BorderTop = BorderStyle.NONE;
            cell30.CellStyle.BorderBottom = BorderStyle.NONE;
            cell30.CellStyle.BorderLeft = BorderStyle.NONE;
            cell30.CellStyle.BorderRight = BorderStyle.NONE;
            region = new CellRangeAddress(3, 3, 0, 11);
            sheet.AddMergedRegion(region);

            //表头第四行
            IRow row4 = sheet.CreateRow(4);
            row4.HeightInPoints = 20;
            ICell cell40 = row4.CreateCell(0);
            cell40.SetCellValue("确认人签字：          日期：          ");
            cell40.CellStyle = normalBoldRightStyle;
            cell40.CellStyle.BorderTop = BorderStyle.NONE;
            cell40.CellStyle.BorderBottom = BorderStyle.NONE;
            cell40.CellStyle.BorderLeft = BorderStyle.NONE;
            cell40.CellStyle.BorderRight = BorderStyle.NONE;
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

            //关键绩效指标
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

            //岗位职责指标
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

            //岗位胜任能力指标
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

            //工作态度指标
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

            //否决指标
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

            //关键岗位职责指标
            IRow rowKeyResponse = sheet.GetRow(6);

            ICell cellKeyResponse = rowKeyResponse.CreateCell(2);
            cellKeyResponse.SetCellValue("关键岗位职责指标");
            cellKeyResponse.CellStyle = normalBoldCenterStyle;
            region = new CellRangeAddress(6, 6 + evaluateTable.KeyResponse.Count * 2 - 1, 2, 2);
            sheet.AddMergedRegion(region);
            ((HSSFSheet)sheet).SetEnclosedBorderOfRegion(region, BorderStyle.THIN, NPOI.HSSF.Util.HSSFColor.BLACK.index);

            //关键岗位胜任能力指标
            IRow rowKeyQualify = sheet.GetRow(6 + evaluateTable.KeyResponse.Count * 2);

            ICell cellKeyQualify = rowKeyQualify.CreateCell(2);
            cellKeyQualify.SetCellValue("关键岗位胜任能力指标");
            cellKeyQualify.CellStyle = normalBoldCenterStyle;
            region = new CellRangeAddress(6 + evaluateTable.KeyResponse.Count * 2, 6 + (evaluateTable.KeyResponse.Count + evaluateTable.KeyQualify.Count) * 2 - 1, 2, 2);
            sheet.AddMergedRegion(region);
            ((HSSFSheet)sheet).SetEnclosedBorderOfRegion(region, BorderStyle.THIN, NPOI.HSSF.Util.HSSFColor.BLACK.index);

            //关键工作态度指标
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

            //否决指标
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
            cellFoot1.CellStyle = normalStyle;
            cellFoot1.CellStyle.BorderTop = BorderStyle.NONE;
            cellFoot1.CellStyle.BorderBottom = BorderStyle.NONE;
            cellFoot1.CellStyle.BorderLeft = BorderStyle.NONE;
            cellFoot1.CellStyle.BorderRight = BorderStyle.NONE;
            region = new CellRangeAddress(6 + (keyCount + evaluateTable.Response.Count + evaluateTable.Qualify.Count + evaluateTable.Attitude.Count) * 2 + 3, 6 + (keyCount + evaluateTable.Response.Count + evaluateTable.Qualify.Count + evaluateTable.Attitude.Count) * 2 + 3, 0, 11);
            sheet.AddMergedRegion(region);

            IRow rowFoot2 = sheet.CreateRow(6 + (keyCount + evaluateTable.Response.Count + evaluateTable.Qualify.Count + evaluateTable.Attitude.Count) * 2 + 4);
            ICell cellFoot2 = rowFoot2.CreateCell(0);
            cellFoot2.SetCellValue("计分人签名：");
            cellFoot2.CellStyle = normalStyle;
            cellFoot2.CellStyle.BorderTop = BorderStyle.NONE;
            cellFoot2.CellStyle.BorderBottom = BorderStyle.NONE;
            cellFoot2.CellStyle.BorderLeft = BorderStyle.NONE;
            cellFoot2.CellStyle.BorderRight = BorderStyle.NONE;
            region = new CellRangeAddress(6 + (keyCount + evaluateTable.Response.Count + evaluateTable.Qualify.Count + evaluateTable.Attitude.Count) * 2 + 4, 6 + (keyCount + evaluateTable.Response.Count + evaluateTable.Qualify.Count + evaluateTable.Attitude.Count) * 2 + 4, 0, 3);
            sheet.AddMergedRegion(region);

            ICell cellFoot3 = rowFoot2.CreateCell(4);
            cellFoot3.SetCellValue("审核人签名：");
            cellFoot3.CellStyle = normalStyle;
            cellFoot3.CellStyle.BorderTop = BorderStyle.NONE;
            cellFoot3.CellStyle.BorderBottom = BorderStyle.NONE;
            cellFoot3.CellStyle.BorderLeft = BorderStyle.NONE;
            cellFoot3.CellStyle.BorderRight = BorderStyle.NONE;
            region = new CellRangeAddress(6 + (keyCount + evaluateTable.Response.Count + evaluateTable.Qualify.Count + evaluateTable.Attitude.Count) * 2 + 4, 6 + (keyCount + evaluateTable.Response.Count + evaluateTable.Qualify.Count + evaluateTable.Attitude.Count) * 2 + 4, 4, 11);
            sheet.AddMergedRegion(region);

            IRow rowFoot3 = sheet.CreateRow(6 + (keyCount + evaluateTable.Response.Count + evaluateTable.Qualify.Count + evaluateTable.Attitude.Count) * 2 + 5);
            ICell cellFoot4 = rowFoot3.CreateCell(0);
            cellFoot4.SetCellValue("日期：    年  月  日");
            cellFoot4.CellStyle = normalStyle;
            cellFoot4.CellStyle.BorderTop = BorderStyle.NONE;
            cellFoot4.CellStyle.BorderBottom = BorderStyle.NONE;
            cellFoot4.CellStyle.BorderLeft = BorderStyle.NONE;
            cellFoot4.CellStyle.BorderRight = BorderStyle.NONE;
            region = new CellRangeAddress(6 + (keyCount + evaluateTable.Response.Count + evaluateTable.Qualify.Count + evaluateTable.Attitude.Count) * 2 + 5, 6 + (keyCount + evaluateTable.Response.Count + evaluateTable.Qualify.Count + evaluateTable.Attitude.Count) * 2 + 5, 0, 3);
            sheet.AddMergedRegion(region);

            ICell cellFoot5 = rowFoot3.CreateCell(4);
            cellFoot5.SetCellValue("日期：    年  月  日");
            cellFoot5.CellStyle = normalStyle;
            cellFoot5.CellStyle.BorderTop = BorderStyle.NONE;
            cellFoot5.CellStyle.BorderBottom = BorderStyle.NONE;
            cellFoot5.CellStyle.BorderLeft = BorderStyle.NONE;
            cellFoot5.CellStyle.BorderRight = BorderStyle.NONE;
            region = new CellRangeAddress(6 + (keyCount + evaluateTable.Response.Count + evaluateTable.Qualify.Count + evaluateTable.Attitude.Count) * 2 + 5, 6 + (keyCount + evaluateTable.Response.Count + evaluateTable.Qualify.Count + evaluateTable.Attitude.Count) * 2 + 5, 4, 11);
            sheet.AddMergedRegion(region);

            if (writeToFile(hssfworkbook, evaluateTable.EvaluatedName, ref filename))
            {
                return true;
            }
            else
            {
                exception = "创建文件失败！";
                return false;
            }
        }

        #region Private Method
        private static bool writeToFile(HSSFWorkbook hssfworkbook, string evaluatedName, ref string filename)
        {
            filename = DateTime.Now.ToString("yyyy-mm-dd-HH-mm-ss") + evaluatedName + @"的考核表.xls";
            string path = System.AppDomain.CurrentDomain.BaseDirectory.ToString() + @"downloadfiles\\" + filename;
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
        #endregion
    }
}
