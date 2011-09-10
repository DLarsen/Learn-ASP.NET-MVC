$(function () {
    $('#sidebar').click(function (e) {
        e.preventDefault();
        $('#popup').fadeIn(200);
    });

    $('#guava_cancel').click(function (e) {
        e.preventDefault();
        $('#popup').fadeOut(200);
    });


});