using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace WebApp
{
    public class ServiceApi
    {
        private readonly HttpClient client;

        public ServiceApi(HttpClient client)
        {
            this.client = client;
        }
        //Cliente
        public async Task<IEnumerable<ClienteEntity>> ClienteGet()
        {
            var result = await client.ServicioGetAsync<IEnumerable<ClienteEntity>>("api/Cliente");
            return result;
        }

        public async Task<IEnumerable<ClienteEntity>> ClienteGetLista()
        {
            var result = await client.ServicioGetAsync<IEnumerable<ClienteEntity>>("api/Cliente");
            return result;
        }

        public async Task<ClienteEntity> ClienteGetById(int id)
        {
            var result = await client.ServicioGetAsync<ClienteEntity>("api/Cliente/" + id);
            if (result.CodeError is not 0) throw new Exception(result.MsgError);
            return result;
        }
        //Producto
        public async Task<IEnumerable<ProductoEntity>> ProductoGet()
        {
            var result = await client.ServicioGetAsync<IEnumerable<ProductoEntity>>("api/Producto");
            return result;
        }

        public async Task<IEnumerable<ProductoEntity>> ProductoGetLista()
        {
            var result = await client.ServicioGetAsync<IEnumerable<ProductoEntity>>("api/Producto");
            return result;
        }

        public async Task<ProductoEntity> ProductoGetById(int id)
        {
            var result = await client.ServicioGetAsync<ProductoEntity>("api/Producto/" + id);
            if (result.CodeError is not 0) throw new Exception(result.MsgError);
            return result;
        }
        //Compra
        public async Task<IEnumerable<CompraEntity>> CompraGet()
        {
            var result = await client.ServicioGetAsync<IEnumerable<CompraEntity>>("api/Compra");
            return result;
        }

        public async Task<CompraEntity> CompraGetById(int id)
        {
            var result = await client.ServicioGetAsync<CompraEntity>("api/Compra/" + id);
            if (result.CodeError is not 0) throw new Exception(result.MsgError);
            return result;
        }

    }
}
