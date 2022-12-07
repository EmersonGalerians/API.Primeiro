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
    public class estados : ControllerBase
    {
        [HttpGet]
        public string est_List(string k_nome)
        {

            string ChaveConexao = "Data Source=10.39.45.44; Initial Catalog=TI_Noite; User ID=Turma2022;Password=Turma2022@2022";

            DataSet DataSetCEP = new DataSet();

            SqlConnection Conexao = new SqlConnection(ChaveConexao);
            Conexao.Open();
            string wQuery = $"select * from estado where estado like '%{k_nome}%'";
            SqlDataAdapter adapter = new SqlDataAdapter(wQuery, Conexao);
            adapter.Fill(DataSetCEP);

            string json = JsonConvert.SerializeObject(DataSetCEP, Formatting.Indented);

            return json;
        }
        [HttpPost]
        public string est_List2(string k_nome)
        {

            string ChaveConexao = "Data Source=10.39.45.44; Initial Catalog=TI_Noite; User ID=Turma2022;Password=Turma2022@2022";

            DataSet DataSetCEP = new DataSet();

            SqlConnection Conexao = new SqlConnection(ChaveConexao);
            Conexao.Open();
            string wQuery = $"select * from estado where estado like '%{k_nome}%'";
            SqlDataAdapter adapter = new SqlDataAdapter(wQuery, Conexao);
            adapter.Fill(DataSetCEP);

            string json = JsonConvert.SerializeObject(DataSetCEP, Formatting.Indented);

            return json;
        }
    }
}
