var submitUri = null;
var bar = $('.progress-bar');
var percent = $('.percent');
var _fileName = "";
var fileSize = "";
var pFileId = "";
var iFileId = "";
var lstModifiedDateTime = "";

$scope.$watch('fileStatus', function (fileStatus) {
    if (fileStatus) {
       
        var valNew = fileStatus.split('===');
        var sSuccessMsg = valNew[0];
        var sFileName = valNew[1];
     //   var uri = valNew[2]; // Added for testing
        if (sSuccessMsg) {
            $scope.IsInitializing = true;
            $scope.checkStatusInterval(sSuccessMsg, sFileName, sFileName.split('==')[3]);
        }
    }
});

$scope.UploadToUrl = function (url) {
  
    $scope.isShowMsg = false;
    $scope.isbtnAttachmentUpload = "disabled";
    var fileExtn = $('#attach_filename').val().split('.').pop();

    //if (fileExtn !== "doc" && fileExtn !== "docx" && fileExtn !== "ppt" && fileExtn !== "pptx" && fileExtn !== "pdf") {
    //    $('#errorModel').modal('toggle');
    //    $scope.isbtnAttachmentUpload = "";
    //    return false;
    //}

    // For Progress baar
    filc = $('#attach_filename');
    filec = $('#attach_filename').val();
    //var url = '/frmEmailTemplate/ParamsOutput' + location.search;
    var payload = { filename: filec };
    payload = JSON.stringify(payload);
    var payloaddata = { key: 'sas', Params: payload, __RequestVerificationToken: $('input[name="__RequestVerificationToken"]').val() };
    // generic fxn
    $scope.UploadFile(url, payloaddata, true, true);
}

$scope.checkStatusInterval = function (valMsg, flName, contnetUnit) {
  
    if (contnetUnit == "true") {
        if (valMsg == "success") {
          
            $('#spnMsg').html("<i class='fa fa-check-circle fa-2x' style='color: green'></i>  Your file has been uploaded successfully, if you want to upload another file so please continue with same process.");
            $scope.UploadFiles.push({ bloborgname: $('#attach_filename').val().split('\\')[2], blobname: flName.split("==")[0], filesize: flName.split("==")[1], lastmodified: new Date(flName.split("==")[2] * 1000).toGMTString() });
            $scope.isShowMsg = true;
            console.log($scope.UploadFiles);
            $scope.isbtnAttachmentUpload = "";
            $('#attach_filename').val('');
        }
    }
   

    return false;
}

//$scope.downloadfromurl = function (url, payloaddata, filename) {
//    //debugger;
//   // $scope.downloadfromurl(url,payloaddata, filename, index)
//    $.post(url, payloaddata, function (result) {
//        if (result.success) {
//            debugger;
//            // $('.anchor').add
//           //$('#anchor' + index).attr("href", result.Data);
//           //document.getElementById('anchor'+index).click();
//            window.location.href = result.Data;
//        }
//        else {
//            $('#spnMsg').html("<i class='fa fa-times-circle fa-2x' style='color: red'></i> Sorry !!! File is not available.");
//        }
//    });
//}

$scope.deleteRow = function (index) {
    $scope.UploadFiles.splice(index, 1);
}

$scope.stopFight = function (stop) {
    $interval.cancel(stop);
    console.log('stop');
    $scope.IsInitializing = false;
};