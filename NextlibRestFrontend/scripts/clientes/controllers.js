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
                    $scope.clientes = data;
                })
                .error(function(data){
                    console.log(data);
                });
            }
            $scope.deletarCliente = function(id){
                $http
                .delete("http://localhost:2379/api/clientes/" + id)
                .success(function(data){
                    $scope.carregarClientes();
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
        '$location',
        '$route',
        function($scope, $http, $location, $route){
            $scope.cliente = {};            
            $scope.voltar = function(){ $location.path("/clientes"); }
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
            $scope.salvarCliente = function(){
                $http
                .put("http://localhost:2379/api/clientes/" + $route.current.params.id, $scope.cliente)
                .success(function(data){
                    console.log(data);
                    $location.path("/clientes");
                })
                .error(function(data){
                    console.log(data);
                });
            }
        }
    ]
);

app.controller(
    'clienteCriar', 
    [
        '$scope',
        '$http',
        '$location',
        '$route',
        function($scope, $http, $location, $route){
            $scope.cliente = {};            
            $scope.voltar = function(){ $location.path("/clientes"); }
            $scope.salvarCliente = function(){
                $http
                .post("http://localhost:2379/api/clientes", $scope.cliente)
                .success(function(data){
                    console.log(data);
                    $location.path("/clientes");
                })
                .error(function(data){
                    console.log(data);
                });
            }
        }
    ]
);