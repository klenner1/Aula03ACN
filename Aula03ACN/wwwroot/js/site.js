
function calc() {
    var c = $("#c").val();
    $.get("/home/Convert/"+ c, function (data, status) {
        alert("Data: " + data.val + "\nStatus: " + status);
    });
}