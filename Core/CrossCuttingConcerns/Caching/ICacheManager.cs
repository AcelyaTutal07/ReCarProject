using System;
using System.Collections.Generic;
using System.Text;

namespace Core.CrossCuttingConcerns.Caching
{
    //bütün alternatiflerimin interfacesi olucak. Bağımsız
  public  interface ICacheManager
    {
        //objects bütün veri tiplerin bütün koleksiyonşarın base her şey atabliceğimiz için object yazdık

        T Get<T>(string key);
        object Get(string key);
        void Add(string key, object value, int duration);
        bool IsAdd(string key); //cache de yoksa veritabanindan getir beritabanında yoksa cache her türlü yaz
        void Remove(string key); //cache den uçurma
        void RemoveByPattern(string pattern); //başı sonu önemki değil get yada ne istiyosan onu 

    }
}
