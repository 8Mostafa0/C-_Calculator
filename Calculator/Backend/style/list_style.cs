namespace Calculator.Backend.style
{
    internal class list_style
    {
        //set style and headers for history list
        public void Set_histoey_headers(DataGridView SelectedList)
        {
            SelectedList.EditMode = DataGridViewEditMode.EditProgrammatically;
            SelectedList.BorderStyle = BorderStyle.None;
            SelectedList.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            SelectedList.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            SelectedList.BackgroundColor = Color.FromArgb(30, 30, 30);
            SelectedList.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            SelectedList.EnableHeadersVisualStyles = false;
            SelectedList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            SelectedList.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 37, 38);
            SelectedList.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            SelectedList.RightToLeft = RightToLeft.Yes;
            SelectedList.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            SelectedList.Columns.Clear();
            SelectedList.Columns.Add("id", "");
            SelectedList.Columns[0].DataPropertyName = "id";
            SelectedList.Columns[0].HeaderText = "آیدی";
            SelectedList.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            SelectedList.Columns.Add("equation", "");
            SelectedList.Columns[1].DataPropertyName = "equation";
            SelectedList.Columns[1].HeaderText = "عملیات";
            SelectedList.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            SelectedList.Columns.Add("result", "");
            SelectedList.Columns[2].DataPropertyName = "result";
            SelectedList.Columns[2].HeaderText = "نتیجه";
        }
    }
}
