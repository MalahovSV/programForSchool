using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace TestProject.Classes
{
    internal class ExportToExcel
    {
        
        static public void WriteDataTable(DataTable dataTable, string idUser)
        {

            DataTable dataTeacher = DBUtils.LoadList($@"select CONCAT(surname, ' ', first_name, ' ', secondname) as 'teacher', concat(number, letter) as 'class' from class_teacher, users, class
where fk_user = id_user and fk_class_teacher = id_teacher and id_user = {idUser}");



            // Создаём экземпляр нашего приложения
            Excel.Application excelApp = new Excel.Application();
            // Создаём экземпляр рабочий книги Excel
            Excel.Workbook workBook;
            // Создаём экземпляр листа Excel
            Excel.Worksheet workSheet;

            

            workBook = excelApp.Workbooks.Add();
            workSheet = (Excel.Worksheet)workBook.Worksheets.get_Item(1);


            workSheet.Cells[1, 1] = $"Таблица учеников {dataTeacher.Rows[0].ItemArray[1].ToString()} класса, учавствоваших в мероприятиях.";
            Excel.Range begin = workSheet.Cells[1, 1];
            Excel.Range end = workSheet.Cells[2, 8];
            Excel.Range topDoc = workSheet.get_Range(begin, end);
            topDoc.Merge(Type.Missing);
            topDoc.Cells.Font.Size = 14;
            topDoc.Font.Name = "Times New Roman";
            topDoc.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
            topDoc.HorizontalAlignment = Excel.XlVAlign.xlVAlignCenter;



            DrawTablePupils(dataTable, workSheet);

            WriteDataInTablePupils(dataTable, workSheet);

            // Открываем созданный excel-файл
            excelApp.Visible = true;
            excelApp.UserControl = true;
        }

        private static void WriteDataInTablePupils(DataTable dataTable, Excel.Worksheet workSheet)
        {
            workSheet.Cells[3, 1] = " № п/п";
            workSheet.Cells[3, 2] = "ФИО ученика";
            workSheet.Cells[3, 3] = "Дата мероприятия";
            workSheet.Cells[3, 4] = "Мероприятие";
            workSheet.Cells[3, 5] = "Вид мероприятия";
            workSheet.Cells[3, 6] = "Результат";
            workSheet.Cells[3, 7] = "Уровень";
            workSheet.Cells[3, 8] = "Место проведения";

            for (int j = 0; j < dataTable.Rows.Count; j++)
            {
                workSheet.Cells[j + 4, 1] = j + 1;
                workSheet.Cells[j + 4, 2] = dataTable.Rows[j].ItemArray[1].ToString();
                workSheet.Cells[j + 4, 3] = DateTime.Parse(dataTable.Rows[j].ItemArray[2].ToString()).ToLongDateString();
                workSheet.Cells[j + 4, 4] = dataTable.Rows[j].ItemArray[4].ToString();
                workSheet.Cells[j + 4, 5] = dataTable.Rows[j].ItemArray[6].ToString();
                workSheet.Cells[j + 4, 6] = dataTable.Rows[j].ItemArray[3].ToString();
                workSheet.Cells[j + 4, 7] = dataTable.Rows[j].ItemArray[5].ToString();
                workSheet.Cells[j + 4, 8] = dataTable.Rows[j].ItemArray[7].ToString();
            }

            workSheet.Columns[1].AutoFit();
            workSheet.Columns[2].AutoFit();
            workSheet.Columns[3].AutoFit();
            workSheet.Columns[4].AutoFit();
            workSheet.Columns[5].AutoFit();
            workSheet.Columns[6].AutoFit();
            workSheet.Columns[7].AutoFit();
            workSheet.Columns[8].AutoFit();
        }

        private static void DrawTablePupils(DataTable dataTable, Excel.Worksheet workSheet)
        {
            Excel.Range r1 = workSheet.Cells[3, 1];
            Excel.Range r2 = workSheet.Cells[dataTable.Columns.Count + 1, 8];
            Excel.Range tablePupils = workSheet.get_Range(r1, r2);
            tablePupils.Borders.Color = ColorTranslator.ToOle(Color.Black);
            tablePupils.Cells.Font.Name = "Times New Roman";
            tablePupils.Cells.Font.Size = 12;
        }
    }
}
