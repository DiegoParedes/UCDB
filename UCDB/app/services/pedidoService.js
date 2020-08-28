app.service('pedidoService', ['$http', function ($http) {

    this.obter = function () {
        return $http.get("/api/Pedidos/GetPedidos");
    }

    this.obterPedidosPorId = function (pedidoId) {
        return $http.get("/api/Pedidos/GetPedidos?pedidoId=" + pedidoId);
    }

}]);