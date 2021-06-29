using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    static class Localization
    {
        public static void LocalFrmLoadOrCreate(FrmLoadOrCreateFile form, bool isEnglish)
        {
            if (!isEnglish)
            {
                form.BtnOpen.Text = "Открыть";
                form.BtnCreate.Text = "Создать";
                form.BtnClose.Text = "Отмена";
                form.LblTitle.Text = "Файл:";
                form.textInput = "Введите имя файла";
                form.textError[0] = "Ошибка при открытии файла. Проверьте: первая строчка- тип данных";
                form.textError[1] = "Ошибка в имени файла";
                form.textError[2] = "Открыть файл";
                form.Text = "Открытие файла";
                form.Titles[0] = "Ошибка";
                form.Titles[1] = "Уведомление";
                if (form.listBox.Items[0].ToString() == "--History is empty--")
                {
                    form.listBox.Items.Clear();
                    form.listBox.Items.Add("--История пуста--");
                }
            }
            else
            {
                form.BtnOpen.Text = "Open";
                form.BtnCreate.Text = "Create";
                form.BtnClose.Text = "Cancel";
                form.LblTitle.Text = "File:";
                form.textInput = "Input file name";
                form.textError[0] = "Error when opening the file. Check: the first line is the data type";
                form.textError[1] = "Error in the file name";
                form.textError[2] = "Open a file";
                form.Text = "Opening a file";
                form.Titles[0] = "Error";
                form.Titles[1] = "Notification";
                if (form.listBox.Items[0].ToString() == "--История пуста--")
                {
                    form.listBox.Items.Clear();
                    form.listBox.Items.Add("--History is empty--");
                }

            }
            form.TextBox.Text = form.textInput;
        }
    }
}
