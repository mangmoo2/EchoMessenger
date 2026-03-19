using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Echo_Messenger
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string typed_msg;  // text박스에 입력된 변수 담고
            typed_msg = textBox1.Text;
            listBox1.Items.Add(typed_msg); // 리스트 박스의 아이템 목록에 추가하기
            textBox1.Clear();  // 텍스트 박스 내용 삭제 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
