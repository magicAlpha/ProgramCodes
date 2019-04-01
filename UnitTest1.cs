using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.IO;
using Xunit;
using Xunit.Sdk;




namespace SeleniumTest
{
    public class UnitTest1
    {








        [Fact]
        public void GetDataOfTestCase(){
            try
            {
                Dictionary<string, string> orderData = null;
                string TestCaseName = "TC_001";
                
                IWorkbook workbook = GetWorkBook("D:\\TestBook.xlsx");
                ISheet sheet= workbook.GetSheet("Sheet1");
                int rowNum=sheet.LastRowNum;
                for (int i=1;i<= rowNum; i++)
                {
                    IRow row= sheet.GetRow(i);
                    ICell cell= row.GetCell(0, MissingCellPolicy.CREATE_NULL_AS_BLANK);
                    cell.SetCellType(CellType.String);
                    string cellValue=cell.StringCellValue;
                    if (cellValue.Equals(TestCaseName))
                    {
                        orderData=new Dictionary<string, string>();
                        int cellNum=row.LastCellNum;
                        for (int j=1;j<=cellNum-1;j+=2)
                        {
							ICell cellObj=row.GetCell(j, MissingCellPolicy.CREATE_NULL_AS_BLANK);
							cellObj.SetCellType(CellType.String);
                            string key = cellObj.StringCellValue;

							ICell nextCellObj = row.GetCell(j + 1, MissingCellPolicy.CREATE_NULL_AS_BLANK);
							nextCellObj.SetCellType(CellType.String);
                            string value = nextCellObj.StringCellValue;

                            orderData.Add(key,value);
                        }
                    }
                }
            } catch (Exception e) {
                throw e;
            }
        }


		[Fact]
		public void GetSheetData()
		{
			try
			{
				string testCaseName;
				Dictionary<string, string> orderData = null;
				Dictionary<string, Dictionary<string, string>> sheetData = null;
				
				//string TestCaseName = "TC_001";

				IWorkbook workbook = GetWorkBook("D:\\TestBook.xlsx");
				 ISheet sheet = workbook.GetSheet("Sheet1");
				 string sheetName=sheet.SheetName;
				 int rowNum = sheet.LastRowNum;
				 sheetData = new Dictionary<string, Dictionary<string, string>>();
				  for (int i = 1; i <= rowNum; i++)
				  {
					IRow row = sheet.GetRow(i);
					ICell cell = row.GetCell(0, MissingCellPolicy.CREATE_NULL_AS_BLANK);
					cell.SetCellType(CellType.String);
					testCaseName = cell.StringCellValue;
						orderData = new Dictionary<string, string>();
						int cellNum = row.LastCellNum;
						for (int j = 1; j <= cellNum - 1; j += 2)
						{
							ICell cellObj = row.GetCell(j, MissingCellPolicy.CREATE_NULL_AS_BLANK);
							cellObj.SetCellType(CellType.String);
							string key = cellObj.StringCellValue;

							ICell nextCellObj = row.GetCell(j + 1, MissingCellPolicy.CREATE_NULL_AS_BLANK);
							nextCellObj.SetCellType(CellType.String);
							string value = nextCellObj.StringCellValue;

							orderData.Add(key, value);
						}
						sheetData.Add(testCaseName, orderData);
				  }
			}
			catch (Exception e)
			{
				throw e;
			}
		}


		[Fact]
		public void GetAllSheetData()
		{
			try
			{
				string testCaseName;
				Dictionary<string, string> orderData = null;
				Dictionary<string, Dictionary<string, string>> sheetData = null;
				Dictionary<string, Dictionary<string, Dictionary<string, string>>> allSheetData = null;
				//string TestCaseName = "TC_001";

				IWorkbook workbook = GetWorkBook("D:\\TestBook.xlsx");
				//var path = Directory.GetCurrentDirectory() + "\\DataTest\\" + fileName + " (" + date + ").csv";

				allSheetData =new Dictionary<string, Dictionary<string, Dictionary<string, string>>>();
				int sheetCounts = workbook.NumberOfSheets;
				for (int l = 0; l <= sheetCounts - 1; l++)
				{
					ISheet sheet = workbook.GetSheetAt(l);
					string sheetName = sheet.SheetName;
					int rowNum = sheet.LastRowNum;
					sheetData = new Dictionary<string, Dictionary<string, string>>();
					for (int i = 1; i <= rowNum; i++)
					{
						IRow row = sheet.GetRow(i);
						ICell cell = row.GetCell(0, MissingCellPolicy.CREATE_NULL_AS_BLANK);
						cell.SetCellType(CellType.String);
						testCaseName = cell.StringCellValue;

						orderData = new Dictionary<string, string>();
						int cellNum = row.LastCellNum;
						for (int j = 1; j <= cellNum - 1; j += 2)
						{
							ICell cellObj = row.GetCell(j, MissingCellPolicy.CREATE_NULL_AS_BLANK);
							cellObj.SetCellType(CellType.String);
							string key = cellObj.StringCellValue;

							ICell nextCellObj = row.GetCell(j + 1, MissingCellPolicy.CREATE_NULL_AS_BLANK);
							nextCellObj.SetCellType(CellType.String);
							string value = nextCellObj.StringCellValue;

							orderData.Add(key, value);
						}
						sheetData.Add(testCaseName, orderData);
					}
					allSheetData.Add(sheetName, sheetData);
				}
			}
			catch (Exception e)
			{
				throw e;
			}
		}



		private IWorkbook GetWorkBook(string path)
        {
            IWorkbook workbook = null;
            FileStream file = new FileStream(@path, FileMode.Open, FileAccess.Read);
            if (path.EndsWith("xlsx"))
            {
                workbook=new XSSFWorkbook(file);
            }
            else{
                workbook = new HSSFWorkbook(file);
            }
            return workbook;
        }
        


    }
}
