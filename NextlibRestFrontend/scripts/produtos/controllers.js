var app = angular.module('nextApp.produtos.controllers', []);

app.controller(
    'produtoLista', 
    [
        '$scope',
        '$http',
        function($scope, $http){

            $scope.produtos = [];
            $scope.carregar = function(){
                $http
                .get("http://localhost:2379/api/produtos")
                .success(function(data){
                    $scope.produtos = data;
                })
                .error(function(data){
                    console.log(data);
                });
            }
            $scope.deletar = function(id){
                $http
                .delete("http://localhost:2379/api/produtos/" + id)
                .success(function(data){
                    $scope.carregar();
                })
                .error(function(data){
                    console.log(data);
                });
            }
        }
    ]
);

app.controller(
    'produtoEditar', 
    [
        '$scope',
        '$http',
        '$location',
        '$route',
        function($scope, $http, $location, $route){
            $scope.produto = {};            
            $scope.voltar = function(){ $location.path("/produtos"); }
            $scope.carregar = function(){
                $http
                .get("http://localhost:2379/api/produtos/" + $route.current.params.id)
                .success(function(data){
                    console.log(data);
                    $scope.produto = data;
                })
                .error(function(data){
                    console.log(data);
                });
            }
            $scope.salvar = function(){
                $http
                .put("http://localhost:2379/api/produtos/" + $route.current.params.id, $scope.produto)
                .success(function(data){
                    console.log(data);
                    $location.path("/produtos");
                })
                .error(function(data){
                    console.log(data);
                });
            }
        }
    ]
);

app.controller(
    'produtoCriar', 
    [
        '$scope',
        '$http',
        '$location',
        '$route',
        function($scope, $http, $location, $route){
            $scope.produto = {};            
            $scope.voltar = function(){ $location.path("/produtos"); }
            $scope.salvar = function(){
                $http
                .post("http://localhost:2379/api/produtos", $scope.produto)
                .success(function(data){
                    console.log(data);
                    $location.path("/produtos");
                })
                .error(function(data){
                    console.log(data);
                });
            }
        }
    ]
);