var app = angular.module('nextApp.clientes.controllers', []);

app.controller(
    'clientesLista', 
    [
        '$scope',
        '$http',
        function($scope, $http){

            $scope.clientes = [];
            $scope.carregarClientes = function(){
                $http
                .get("http://localhost:2379/api/clientes")
                .success(function(data){
                    console.log(data);
                    $scope.clientes = data;
                })
                .error(function(data){
                    console.log(data);
                });
            }
        }
    ]
);

app.controller(
    'clienteEditar', 
    [
        '$scope',
        '$http',
        '$route',
        function($scope, $http, $route){
            $scope.cliente = {};            
            $scope.carregarCliente = function(){
                $http
                .get("http://localhost:2379/api/clientes/" + $route.current.params.id)
                .success(function(data){
                    console.log(data);
                    $scope.cliente = data;
                })
                .error(function(data){
                    console.log(data);
                });
            }
        }
    ]
);