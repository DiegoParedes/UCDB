angular.module("pedidos").controller("pedidosController", function ($scope, $http) {
    $scope.app = "Lista Pedidos";


    function obterPedidos(callback) {
        let pedidos;
        $pedidoService.obter()
            .then(resposta => pedidos = resposta)
            .finally(() => {
                return callback(pedidos.data)
            })

        $scope.pedidos = resposta;
    }
});