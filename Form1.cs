private void btnOrder_Click(object sender, EventArgs e)
{
string meal = txtInput.Text.Trim(); // 

if (string.IsNullOrEmpty(meal))
{
//
MessageBox.Show("請輸入餐點名稱！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
}
else if (meal == "漢堡")
{
// 
MessageBox.Show("漢堡賣完了，要不要試試薯條？");
}
else
{
MessageBox.Show("好的，正在為您準備 " + meal + "...");
}
}
