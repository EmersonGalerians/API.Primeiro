using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace API.Primeiro.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SobreNome : ControllerBase
    {
        [HttpGet]
        public string SN_List(string p_nome)
        {

            string ChaveConexao = "Data Source=10.39.45.44; Initial Catalog=TI_Noite; User ID=Turma2022;Password=Turma2022@2022";

            DataSet DataSetCEP = new DataSet();

            SqlConnection Conexao = new SqlConnection(ChaveConexao);
            Conexao.Open();
            string wQuery = $"select * from SobreNome where Nome like '%{p_nome}%'";
            SqlDataAdapter adapter = new SqlDataAdapter(wQuery, Conexao);
            adapter.Fill(DataSetCEP);

            string json = JsonConvert.SerializeObject(DataSetCEP, Formatting.Indented);

            return json;
        }
        [HttpPost]
        public string SN_List2(string p_nome)
        {

            string ChaveConexao = "Data Source=10.39.45.44; Initial Catalog=TI_Noite; User ID=Turma2022;Password=Turma2022@2022";

            DataSet DataSetCEP = new DataSet();

            SqlConnection Conexao = new SqlConnection(ChaveConexao);
            Conexao.Open();
            string wQuery = $"select * from SobreNome where Nome like '%{p_nome}%'";
            SqlDataAdapter adapter = new SqlDataAdapter(wQuery, Conexao);
            adapter.Fill(DataSetCEP);

            string json = JsonConvert.SerializeObject(DataSetCEP, Formatting.Indented);

            return json;
        }
    }
}
