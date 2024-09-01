using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks; 
using _4;
using static System.Net.Mime.MediaTypeNames;
using System.Data.SqlClient;
using System.Windows.Forms;
using Application = System.Windows.Forms.Application;
using System.Xml;
using System.IO;
using Newtonsoft.Json;


namespace _4
{
    internal class Program
    {

        static void Main(string[] args)
        {
            InputEncoding = Encoding.UTF8;
            OutputEncoding = Encoding.UTF8;

            Title = "Quản lý hàng hóa";

            //Cau 2: Nhap n
            int n = NhapN();
            WriteLine();

            // Câu 3: Nhập hàng hóa
            var hanghoa1 = NhapHangHoa(n);
            WriteLine();
            WriteLine("Thông tin các hàng hóa đã được lưu: ");

            foreach (var hanghoa in hanghoa1)
            {
                WriteLine($"- ID: {hanghoa.ID}, Tên: {hanghoa.Ten}, Giá bán ra: {hanghoa.GiaBan}");
            }
            WriteLine();

            // Câu 3b: Hiển thị hàng hóa có giá nhập >= 100000
            WriteLine("Danh sách hàng hóa có giá nhập >= 100000:");
            foreach (var hanghoa in hanghoa1)
            {
                if (hanghoa.GiaBan >= 100000)
                {
                    WriteLine($"- ID: {hanghoa.ID}, Tên: {hanghoa.Ten}, Giá nhập vào: {hanghoa.GiaBan}");
                }
            }
            WriteLine();

            // Câu 3c: Lưu vào CSDL
            var result = LuuDB(hanghoa1);
            if (result != null)
            {
                WriteLine("Dữ liệu đã được ghi vào cơ sở dữ liệu thành công.");
            }
            else
            {
                WriteLine("null");
            }


          /*  // Câu 3d: Xuất ra file JSON
            string filePath = "hanghoa.json";
            XuatFileJson(hanghoa1, filePath);*/


            ReadKey();
       

            //Cau 4: hien thi Form
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormQLHangHoa());

            
        }

   
   
            //cau 2
            static int NhapN()
        {
            int n;
            while (true)
            {
                try
                {
                    Write("Nhập vào số nguyên dương n (nhỏ hơn 1000): ");
                    n = int.Parse(ReadLine());

                    if (n > 0 && n <= 1000)
                    {
                        break;
                    }
                    else
                    {
                        WriteLine("Số nhập vào phải nhỏ hơn 1000, không bít chọn gì thì chọn 1 hoi cho tau đỡ tốn bộ nhớ. Mãi iu!!!.");
                        WriteLine();
                    }
                }
                catch (FormatException)
                {
                    WriteLine("Bít đọc Tiếng Zịt hong? số nguyên dương nhỏ hơn 1000 nha. Nhập lại đê.");
                    WriteLine();
                }
                catch (Exception ex)
                {
                    WriteLine($"Có lỗi xảy ra: {ex.Message}. Nhập lại cho đúng giùm tau cái coi.");
                    WriteLine();
                }
            }
            WriteLine($"Số bạn đã nhập là: {n}");
            return n;
        }


        // Câu 3a
        public static List<Hanghoa> NhapHangHoa(int n)
        {
            List<Hanghoa> hanghoaList = new List<Hanghoa>();
            int i = 1; // Đếm số lượng hàng hóa đã nhập

            while (i <= n)
            {
                Hanghoa hanghoa = new Hanghoa();
                WriteLine($"Nhập thông tin hàng hóa thứ {i}:");

                // Nhập ID
                Write("ID (hoặc nhập '#' để kết thúc): ");
                string inputID = Console.ReadLine();
                if (inputID == "#")
                {
                    break;
                }

                // Kiểm tra và chuyển đổi ID
                if (string.IsNullOrWhiteSpace(inputID) || !int.TryParse(inputID, out int id))
                {
                    WriteLine("ID không hợp lệ. Vui lòng nhập lại.");
                    continue;
                }
                hanghoa.ID = inputID;

                // Kiểm tra trùng ID
                if (hanghoaList.Any(hh => hh.ID == hanghoa.ID))
                {
                    WriteLine("ID này có gòi nha, nhập ID khác đi.");
                    continue;
                }

                // Nhập MaVach
                Write("Nhập Mã Vạch: ");
                string inputMaVach = Console.ReadLine();
                
                // Kiểm tra và chuyển đổi ID
                if (string.IsNullOrWhiteSpace(inputID) || !int.TryParse(inputID, out int MaVach))
                {
                    WriteLine("Mã vạch không hợp lệ. Vui lòng nhập lại.");
                    continue;
                }
                hanghoa.MaVach = inputMaVach;


                // Nhập Tên Hàng
                Write("Tên Hàng: ");
                hanghoa.Ten = ReadLine();

                // Nhập Giá Bán
                Write("Giá Bán: ");
                string inputGiaBan = ReadLine();
                if (!float.TryParse(inputGiaBan, out float giaBan) || giaBan <= 0)
                {
                    WriteLine("Giá bán không hợp lệ hoặc không lớn hơn 0. Vui lòng nhập lại.");
                    continue;
                }
                hanghoa.GiaBan = giaBan;

                // Thêm hàng hóa vào danh sách
                hanghoaList.Add(hanghoa);
                i++;
            }
            return hanghoaList;
        }


        // Câu 3c: Hàm ghi dữ liệu vào CSDL
        static List<Hanghoa> LuuDB(List<Hanghoa> hanghoaList)
        {
            string connectionString = @"Data Source=Laptop_of_Carat\SQLEXPRESS;Initial Catalog=Hanghoa;Integrated Security=True";

            try
            {
                using (SqlConnection cnn = new SqlConnection(connectionString))
                {
                    cnn.Open();

                    foreach (var hanghoa in hanghoaList)
                    {
                        string query = "INSERT INTO Hanghoa (ID, MaVach, Ten, GiaBan) VALUES (@ID,@MaVach, @Ten, @GiaBan)";

                        using (SqlCommand cmd = new SqlCommand(query, cnn))
                        {
                            cmd.Parameters.AddWithValue("@ID", hanghoa.ID);
                            cmd.Parameters.AddWithValue("@MaVach", hanghoa.MaVach);
                            cmd.Parameters.AddWithValue("@Ten", hanghoa.Ten);
                            cmd.Parameters.AddWithValue("@GiaBan", hanghoa.GiaBan);

                            cmd.ExecuteNonQuery();
                        }
                    }
                }
                return hanghoaList; // Trả về danh sách hàng hóa nếu ghi thành công
            }
            catch (Exception ex)
            {
                WriteLine($"Có lỗi xảy ra: {ex.Message}");
                return null;
            }
        }

      /*  // Câu 3d: Xuất dữ liệu ra file JSON
        public static void XuatFileJson(List<Hanghoa> hanghoaList, string filePath)
        {
            try
            {
                string json = JsonConvert.SerializeObject(hanghoaList, Formatting.Indented);
                File.WriteAllText(filePath, json);
                WriteLine($"Dữ liệu đã được xuất ra file JSON tại: {Path.GetFullPath(filePath)}");
            }
            catch (Exception ex)
            {
                WriteLine("Lỗi khi xuất dữ liệu ra file JSON: " + ex.Message);
            }
        }*/
    }
}


    

