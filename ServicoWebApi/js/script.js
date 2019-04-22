var uri = 'api/Cliente';

function formatar(item) {
    return item.ID + ' - ' + item.Nome + ' - ' + item.Email;
}

$(document).ready(function () {

    $.getJSON(uri).done(function (data) {

        $.each(data, function (key, item) {
            $('<li>', { text: formatar(item) }).appendTo($('#clientes'));
        })

    });

});

function find() {

    var id = $("#ID").val();

    $.getJSON(uri + '/' + id).done(function (data) {
        $('#cliente').text(formatar(data));
    })
}