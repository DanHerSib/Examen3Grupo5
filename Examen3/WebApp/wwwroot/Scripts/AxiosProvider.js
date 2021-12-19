"use strict";
var App;
(function (App) {
    var AxiosProvider;
    (function (AxiosProvider) {
        //export const GuardarEmpleado = () => axios.get<Entity.DBEntity>("aplicacion").then(({data})=>data );
        AxiosProvider.ProductoEliminar = function (id) { return ServiceApi.delete("api/Producto/" + id).then(function (_a) {
            var data = _a.data;
            return data;
        }); };
        AxiosProvider.ProductoInsertar = function (entity) { return ServiceApi.post("api/Producto", entity).then(function (_a) {
            var data = _a.data;
            return data;
        }); };
        AxiosProvider.ProductoActualizar = function (entity) { return ServiceApi.put("api/Producto", entity).then(function (_a) {
            var data = _a.data;
            return data;
        }); };
        AxiosProvider.ClienteEliminar = function (id) { return ServiceApi.delete("api/Cliente/" + id).then(function (_a) {
            var data = _a.data;
            return data;
        }); };
        AxiosProvider.ClienteInsertar = function (entity) { return ServiceApi.post("api/Cliente", entity).then(function (_a) {
            var data = _a.data;
            return data;
        }); };
        AxiosProvider.ClienteActualizar = function (entity) { return ServiceApi.put("api/Cliente", entity).then(function (_a) {
            var data = _a.data;
            return data;
        }); };
        AxiosProvider.CompraEliminar = function (id) { return ServiceApi.delete("api/Compra/" + id).then(function (_a) {
            var data = _a.data;
            return data;
        }); };
        AxiosProvider.CompraInsertar = function (entity) { return ServiceApi.post("api/Cliente", entity).then(function (_a) {
            var data = _a.data;
            return data;
        }); };
        AxiosProvider.CompraActualizar = function (entity) { return ServiceApi.put("api/Cliente", entity).then(function (_a) {
            var data = _a.data;
            return data;
        }); };
    })(AxiosProvider = App.AxiosProvider || (App.AxiosProvider = {}));
})(App || (App = {}));
//# sourceMappingURL=AxiosProvider.js.map