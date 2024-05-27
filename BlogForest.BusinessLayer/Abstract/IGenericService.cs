using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogForest.BusinessLayer.Abstract
{
	public interface IGenericService<T> where T : class
	{
		void TInsert(T entity);
		void TUpdate(T entity);
		void TDelete(T id);
		T TGetById(int id);
		List<T> TGetListAll();
	}
}
