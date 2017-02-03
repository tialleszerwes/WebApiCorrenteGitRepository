var app = angular.module('app');

app.service('pedidoAjudaService', pedidoAjudaService); //TODO: inserir $http

function pedidoAjudaService() {
    debugger;
    this.ListarGrid = function ($scope) {
        debugger;
        $.post('http://localhost:5792/api/PedidoAjuda/ListarTeste', $scope.GridParametros, 'json')
            .done(function (objRetorno) {
                debugger;
                $scope.ListaPedidosAjuda = objRetorno.ListaPedidosAjuda;
                $scope.bigTotalItems = objRetorno.Total;
                $scope.$digest();
                //inicializa os eventos de abrir modal da grid 3D
                new grid3D(document.getElementById('grid3d'));
            }).fail(function (error) {
                alert(error.message)
            });
    }

    this.Salvar = function (pedidoAjudaParam) {
        debugger;
        $.post('http://localhost:5792/api/PedidoAjuda/Salvar', pedidoAjudaParam, 'json')
            .done(function (objRetorno) {
                alert("dados salvos com sucesso");
                //TODO: inserir o location search para a grid
            }).fail(function (error) {
                alert(error.message)
            });
    }

    var self = this;
}