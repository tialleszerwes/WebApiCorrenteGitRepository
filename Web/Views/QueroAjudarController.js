
var app = angular.module('app');

app.controller('queroAjudarCtrl', function ($scope, pedidoAjudaService) {
    inicializaObjeto($scope);
    inicializaPartial($scope);


    $scope.selecionarCategoria_Click = function (txtCategoria) {
        $('#secaoGrid').show();
        $('#contact').show();
        $('#lblCabecalhoTarefa').html("Alguém ficará muito feliz com sua escolha");
        $scope.Categoria = txtCategoria;

        $scope.CarregarGrid();
    };

    $scope.CarregarGrid = function () {
        $scope.GridParametros.NumPagina = $scope.bigCurrentPage; //passa a página que deseja acessar
        $scope.GridParametros.RegistrosPorPagina = $scope.totalItems;
        pedidoAjudaService.ListarGrid($scope);
    };

});

function inicializaObjeto($scope) {
    $scope.Status = [];
    $scope.ListaPedidosAjuda = []; //lista de pedidos da grid
    $scope.GridParametros = {
        NumPagina: 0,
        RegistrosPorPagina: 0,
        Total: 0,
        FiltroGrid: {
            //TODO: inserir dados de filtro
        }
    };

    $scope.ItensPorPagina = [
        {
            Codigo: "10", Nome: "Até 10"
        }, {
            Codigo: "20", Nome: "Até 20"
        }, {
            Codigo: "30", Nome: "Até 30"
        }, {
            Codigo: "40", Nome: "Até 40"
        }, {
            Codigo: "50", Nome: "Até 50"
        }
    ];

    $scope.Categoria = null;
    
    $scope.bigCurrentPage = 1; //página atual
    $scope.maxSize = 3; //quantidade de itens na exibição do paginador
    $scope.totalItems = "10"; //total de itens por página com valor default
    $scope.bigTotalItems = 0; //total de itens no banco
}

function inicializaPartial($scope) {
    $scope._viewMasterQueroAjudar = "/Views/QueroAjudar/_viewMasterQueroAjudar.html";
    $scope._viewCategoria = "/Views/QueroAjudar/_viewCategoria.html";
    $scope._viewGrid = "/Views/QueroAjudar/_viewGrid.html";
    $scope._viewContato = "/Views/QueroAjudar/_viewContato.html";
    $scope.viewVisualizarPedido = "/Views/Shared/_modalVisualizarPedido.html";
}