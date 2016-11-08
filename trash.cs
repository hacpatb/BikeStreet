using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace BikeStreet
{
    class trash
    {
        public static void replaceBookmark(Word.Document wDoc, Object bmName, string text)
        {
          //  Word.Bookmark bm;
            wDoc.Bookmarks.get_Item(ref bmName).Range.Text = text;
            // wDoc.Bookmarks.get_Item(ref bmName).Range.InsertParagraphAfter();
            //bm.Range.InsertAfter(text);
        }
        //формирования столбцов в DataGridView
        public static void makeDataGridColumns(DataGridView dgv, dgvDescription[] dgvDsc, bool autosize = false)
        {
            DataGridViewTextBoxColumn textCol;
            DataGridViewCheckBoxColumn checkCol;
            DataGridViewButtonColumn buttonCol;
            DataGridViewComboBoxColumn textComboBox;

            if (autosize)
            {
                //dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }

            foreach (dgvDescription dsc in dgvDsc)
            {
                switch (dsc.type)
                {
                    case 0:
                        textCol = new DataGridViewTextBoxColumn();
                        textCol.DataPropertyName = dsc.DataPropertyName;
                        textCol.Name = dsc.Name;
                        textCol.HeaderText = dsc.HeaderText;
                        if (!autosize) textCol.Width = dsc.Width;
                        else textCol.FillWeight = dsc.Width;
                        textCol.SortMode = DataGridViewColumnSortMode.NotSortable;
                        dgv.Columns.Add(textCol);
                        break;
                    case 1:
                        checkCol = new DataGridViewCheckBoxColumn();
                        checkCol.DataPropertyName = dsc.DataPropertyName;
                        checkCol.Name = dsc.Name;
                        checkCol.HeaderText = dsc.HeaderText;
                        checkCol.Width = dsc.Width;
                        checkCol.SortMode = DataGridViewColumnSortMode.NotSortable;
                        dgv.Columns.Add(checkCol);
                        break;
                    case 2:
                        buttonCol = new DataGridViewButtonColumn();
                        buttonCol.Name = dsc.Name;
                        buttonCol.HeaderText = dsc.HeaderText;
                        buttonCol.Width = dsc.Width;
                        buttonCol.SortMode = DataGridViewColumnSortMode.NotSortable;
                        dgv.Columns.Add(buttonCol);
                        break;
                    case 3:
                        textComboBox = new DataGridViewComboBoxColumn();
                        textComboBox.Name = dsc.Name;
                        textComboBox.HeaderText = dsc.HeaderText;
                        textComboBox.Width = dsc.Width;
                        textComboBox.SortMode = DataGridViewColumnSortMode.NotSortable;
                        dgv.Columns.Add(textComboBox);
                        break;

                }
            }
        }
    }
    class dgvDescription
    {
        public int type { get; set; }
        public string DataPropertyName { get; set; }
        public string Name { get; set; }
        public string HeaderText { get; set; }
        public int Width { get; set; }

        public dgvDescription(int t, string DPN, string N, string HT, int W)
        {
            type = t;
            DataPropertyName = DPN;
            Name = N;
            HeaderText = HT;
            Width = W;
        }
    }
}
