var app = angular.module('spartaApp', ['ngIle']);


app.config(['KeepaliveProvider', 'IdleProvider', function (KeepaliveProvider, IdleProvider) {
	IdleProvider.idle(5);
	IdleProvider.timeout(5);
	KeepaliveProvider.interval(10);
}]);