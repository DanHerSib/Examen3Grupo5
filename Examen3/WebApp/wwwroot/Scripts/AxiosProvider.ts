
namespace App.AxiosProvider   {

    //export const GuardarEmpleado = () => axios.get<Entity.DBEntity>("aplicacion").then(({data})=>data );
    export const ProductoEliminar = (id) => ServiceApi.delete<DBEntity>("api/Producto/" + id).then(({ data }) => data);
    export const ProductoInsertar = (entity) => ServiceApi.post<DBEntity>("api/Producto", entity).then(({ data }) => data);
    export const ProductoActualizar = (entity) => ServiceApi.put<DBEntity>("api/Producto", entity).then(({ data }) => data);

    export const ClienteEliminar = (id) => ServiceApi.delete<DBEntity>("api/Cliente/" + id).then(({ data }) => data);
    export const ClienteInsertar = (entity) => ServiceApi.post<DBEntity>("api/Cliente", entity).then(({ data }) => data);
    export const ClienteActualizar = (entity) => ServiceApi.put<DBEntity>("api/Cliente", entity).then(({ data }) => data);

    export const CompraEliminar = (id) => ServiceApi.delete<DBEntity>("api/Compra/" + id).then(({ data }) => data);
    export const CompraInsertar = (entity) => ServiceApi.post<DBEntity>("api/Cliente", entity).then(({ data }) => data);
    export const CompraActualizar = (entity) => ServiceApi.put<DBEntity>("api/Cliente", entity).then(({ data }) => data);
}




