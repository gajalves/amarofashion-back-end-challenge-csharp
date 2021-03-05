using amaro_back_end.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace amaro_back_end.Repositories
{
    public class ProdutoRepository
    {                
        
        public List<Produtos> GetProdutos(int offset, int limit)
        {
            string query = @"select * 
                             from produtos 
                             order by id";

            query += offset != 0 ? " offset " + offset : "";
            query += limit != 0 ? " limit " + limit : "";

            var result = BaseRepository.QuerySql<Produtos>(query);

            return result;           
        }

        public Produtos GetProdutoByControleExterno(int controleexterno)
        {
            string query = "select * from produtos prod where prod.controleexterno = " + controleexterno;

            var result = BaseRepository.QuerySql<Produtos>(query).FirstOrDefault();

            return result;
        }
    }
}
