
    $scope.model1 = JSON.parse($("#model_json1").val());
    debugger;
    var Inloadmodel = function (result) {
        $scope.model1 = result;
        $scope.VMS = $scope.model1.dsForm.RevNum;
        debugger;
        $scope.dsCombo = $scope.model.dsCombo;
        $scope.ValueLists = $scope.model.ValueLists;
        //@Html.RenderLookup("VMS", Model, Model.dsForm.Tables(0))
            }
    Inloadmodel($scope.model1);
    //REDIRECT TO Spec2
    $scope.RedirectToSpecs2 = function () {
        $scope.ItemMode = ($scope.model.frmMode == 2 ? false : true);
        if ($scope.model.frmMode == 1 && $scope.ItemMode) {
            $scope.info = $scope.Item;
            //$scope.info.WOTypeSelected = $scope.WO.WOTypeSelected.codeword;
            var base = '/App/Link' + location.search;
            var payload = { fKey: 'frmSpecs2', fMode: 'acAddM', IDX: 0, rowData: JSON.stringify($scope.info) }
            $.post(base, payload, function (result) {
                $scope.status = 'loaded';
                window.location = result;
            });
        }
        else {
            alert("Please Submit form Before Adding HSN");
        }
    }

