$(document).ready(function () {
    ShowAllReservation();

    function ShowAllReservation() {
        $("table tbody").html("");
        $.ajax({
            url: "https://localhost:7123/api/Reservation",
            type: "get",
            contentType: "application/json",
            success: function (result, status, xhr) {
                $.each(result, function (index, value) {
                    $("tbody").append($("<tr>"));
                    appendElement = $("tbody tr").last();
                    appendElement.append($("<td>").html(value["id"]));
                    appendElement.append($("<td>").html(value["name"]));
                    appendElement.append($("<td>").html(value["startLocation"]));
                    appendElement.append($("<td>").html(value["endLocation"]));
                    //appendElement.append($("<td>").html("<a href=\"UpdateReservation.html?id=" + value["id"] + "\"><img src=\"icon/edit.png\" /></a>"
                    //appendElement.append($("<td>").html("<img class=\"delete\" src=\"icon/close.png\" />"));
                });
            },
            error: function (xhr, status, error) {
                console.log(xhr)
            }
        });
    }

    $("table").on("click", "img.delete", function () {
        var reservationId = $(this).parents("tr").find("td:nth-child(1)").text();

        $.ajax({
            url: "https://localhost:44324/api/Reservation/" + reservationId,
            type: "delete",
            contentType: "application/json",
            success: function (result, status, xhr) {
                ShowAllReservation();
            },
            error: function (xhr, status, error) {
                console.log(xhr)
            }
        });
    });

});