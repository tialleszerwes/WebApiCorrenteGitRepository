
var app = angular.module('app');

app.controller('precisoAjudaCtrl', function ($scope, pedidoAjudaService) {
    debugger;
    inicializaObjeto($scope);
    inicializaPartial($scope);

    $scope.Salvar = function () {
        debugger;
        pedidoAjudaService.Salvar($scope.PedidoAjuda)
    }
});

function inicializaObjeto($scope) {
    $scope.PedidoAjuda = {
        oQueAconteceu: "",
        Endereco: "",
        Municipio: "",
        Recursos: "",
    };
}

function inicializaPartial($scope) {
    $scope._viewMasterPrecisoAjuda = "/Views/PrecisoAjuda/_viewMasterPrecisoAjuda.html";
    $scope._viewCadastroPrecisoAjuda = "/Views/PrecisoAjuda/_viewCadastroPedido.html";
}