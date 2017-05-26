using System;
using System.Collections.Generic;
using System.Text;
using Compressor.Model;
using  Compressor.DAL;

namespace Compressor.BLL
{
	/// <summary>
	/// CardBLL��
	/// BY�����˴��������� V1.0
	/// ���ߣ���������
	/// ���ڣ�2017��05��11�� 02:23:48
	/// </summary>
	public class CardBLL
	{


		/// <summary>
		/// ��ȡ������Ϣ����
		/// </summary>
		/// <returns>List����</returns>
		public static List<CardInfo> GetCardInfoList(string where)
		{
			try
			{
				return CardDAL.GetCardInfoList(where);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// ���� ���� ��ȡһ��ʵ�����
		/// <param name="CardID">����</param>
		/// </summary>
		public static CardInfo GetCardInfoById(string CardID)
		{
			try
			{
				return CardDAL.GetCardInfoById(CardID);
			}
			catch
			{
				throw;
			}
		}

		/// �������
		/// </summary>
		/// <param name="info">���ݱ�ʵ�����</param>
		public static bool AddCard(CardInfo info)
		{
			try
			{
				return CardDAL.AddCard(info);
			}
			catch
			{
				throw;
			}
		}

		/// <summary>
		/// ��������ɾ��һ������
		/// </summary>
		/// <param name="_CardID">����</param>
		/// <returns></returns>
		public static bool DeleteCardInfo(CardInfo info)
		{
			try
			{
				return CardDAL.DeleteCardInfo(info);
			}
			catch
			{
				throw;
			}
		}

		/// ��������
		/// </summary>
		/// <param name="info">���ݱ�ʵ��</param>
		public static bool UpdateCardInfo(CardInfo info)
		{
			try
			{
				return CardDAL.UpdateCardInfo(info);
			}
			catch
			{
				throw;
			}
		}
	}
}
