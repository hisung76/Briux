/*
 * Created by SharpDevelop.
 * User: SHI
 * Date: 2018-05-09
 * Time: 오후 4:07
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;

namespace Test1
{
	/// <summary>
	/// Interaction logic for Window1.xaml
	/// </summary>
	public partial class Window1 : Window
	{
		public Window1()
		{
			InitializeComponent();
		}
		void button1_Click(object sender, RoutedEventArgs e)
		{
			throw new NotImplementedException();
		}
		void dataGrid1_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			throw new NotImplementedException();
		}
		
		/// <summary>
		/// dfklsdjf
		/// dsklfjslkdj
		/// sdlkfjslkdjf
		/// </summary>
			public class Item1
        {
			/// <summary>
			/// 
			/// </summary>
            public string Header1 { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string Header2 { get; set; }
            public string Header3 { get; set; }
            public string Header4 { get; set; }
        }  
			public class Item2
        {
			/// <summary>
			/// 
			/// </summary>
            public string Header1 { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string Header2 { get; set; }
            public string Header3 { get; set; }
        }  

			
			
 			public class Item8
        {
			/// <summary>
			/// 
			/// </summary>
            public string Header1 { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string Header2 { get; set; }
            public string Header3 { get; set; }
        }
		
		    
		
     
	
		
		
		void mainwindow_Loaded(object sender, RoutedEventArgs e)
		{
			
			
			
			#region "grid1번"
			
			{
			
	            
	            datagrid1.Items.Add(new Item1() { Header1 = "사 업 명", Header2 = "서울~부산간 고속국도 건설공사", Header3 = "발 주 처", Header4 = "한국도로공사" });
	            datagrid1.Items.Add(new Item1() { Header1 = "공 구 명", Header2 = "14공구", Header3 = "교 량 형 식", Header4 = "거더합성형 골조식교량" });
	            datagrid1.Items.Add(new Item1() { Header1 = "교 량 명", Header2 = "장헌교", Header3 = "설 계 사", Header4 = "(주)한맥기술" });
	            datagrid1.Items.Add(new Item1() { Header1 = "교 량 위 치", Header2 = "충청남도 당진시 고대면 성산리", Header3 = "시 공 사", Header4 = "(주)장헌산업" });
	            datagrid1.Items.Add(new Item1() { Header1 = "도 로 등 급", Header2 = "고속도로", Header3 = "노 선 명", Header4 = "고속국도 1호선" });
	            datagrid1.Items.Add(new Item1() { Header1 = "시 점 방 향", Header2 = "서울", Header3 = "추정교통량", Header4 = "10,000 대/일" });
			
			}
			
			#endregion "grid1번"
			
			#region "grid2번"
			
			{
			
	            
	            datagrid2.Items.Add(new Item2() { Header1 = "", Header2 = "고속국도, 자동차전용도로상의 교량", Header3 = "1등교" });
	            datagrid2.Items.Add(new Item2() { Header1 = "", Header2 = "교통량이 많고, 중차량의 통과가 불가피한 도로상의 교량", Header3 = "1등교" });
	            datagrid2.Items.Add(new Item2() { Header1 = "", Header2 = "국방상 중요한 도로상에 가설하는 교량", Header3 = "1등교" });
	            datagrid2.Items.Add(new Item2() { Header1 = "", Header2 = "장대교량(지간장 200m 이상)",Header3 = "1등교" });
	            datagrid2.Items.Add(new Item2() { Header1 = "", Header2 = "중차량의 통과가 빈번한 특수산업시설에 인접한 교량", Header3 = "1등교" });
	            datagrid2.Items.Add(new Item2() { Header1 = "", Header2 = "기타 필요성이 인정되는 교량", Header3 = "1등교" });
	            datagrid2.Items.Add(new Item2() { Header1 = "", Header2 = "일반국도, 특별시도와 지방도상의 교통량이 적은 교량(AADT 1,000대 미만)", Header3 = "2등교" });
	            datagrid2.Items.Add(new Item2() { Header1 = "", Header2 = "시도 및 군도 중에서 중요한 도로상에 가설하는 교량", Header3 = "2등교" });
	            datagrid2.Items.Add(new Item2() { Header1 = "", Header2 = "산간벽지에 있는 교통량이 적은 곳에 가설하는 교량", Header3 = "3등교" });
	            datagrid2.Items.Add(new Item2() { Header1 = "", Header2 = "교통량이 극히 적은 경우 담당기술자의 판단", Header3 = "3등교" });
	            
			
			}
			
			#endregion "grid2번"
			
			
			
			#region "grid8번"
			
			{
			
	            
	            datagrid8.Items.Add(new Item8() { Header1 = "111", Header2 = "222", Header3 = "" });
			
			}
			
			#endregion "grid8번"
			
			
			
			
			
            
			
		}
		void dataGrid2_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			throw new NotImplementedException();
		}
		
	}
}