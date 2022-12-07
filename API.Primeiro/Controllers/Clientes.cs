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
    public class Clientes : ControllerBase
    {
        [HttpGet]
        public string Cont_List(string c_Nome)
        {
            
            string ChaveConexao = "Data Source=10.39.45.44; Initial Catalog=TI_Noite; User ID=Turma2022;Password=Turma2022@2022";

            DataSet DataSetCEP = new DataSet();

            SqlConnection Conexao = new SqlConnection(ChaveConexao);
            Conexao.Open();
            string wQuery = $"select * from Contatos where GivenName like '%{c_Nome}%'";
            SqlDataAdapter adapter = new SqlDataAdapter(wQuery, Conexao);
            adapter.Fill(DataSetCEP);

            string json = JsonConvert.SerializeObject(DataSetCEP, Formatting.Indented);

            return json;
        }
        [HttpPost]
        public string Cont_List2(string c_Nome)
        {

            string ChaveConexao = "Data Source=10.39.45.44; Initial Catalog=TI_Noite; User ID=Turma2022;Password=Turma2022@2022";

            DataSet DataSetCEP = new DataSet();

            SqlConnection Conexao = new SqlConnection(ChaveConexao);
            Conexao.Open();
            string wQuery = $"select * from Contatos where GivenName like '%{c_Nome}%'";
            SqlDataAdapter adapter = new SqlDataAdapter(wQuery, Conexao);
            adapter.Fill(DataSetCEP);

            string json = JsonConvert.SerializeObject(DataSetCEP, Formatting.Indented);

            return json;
        }
    }
}
