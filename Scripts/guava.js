$(function () {

    guavaInit();

    $('#sidebar').click(function (e) {
        e.preventDefault();
        $('#popup').fadeIn(200);
        $('#guava_content').focus();
    });

    $('#guava_cancel').click(function (e) {
        e.preventDefault();
        $('#popup').fadeOut(200);
    });

    $('#guava_post').click(function (e) {
        e.preventDefault();
        var m = $('#guava_content').val();
        $.ajax({
            type: "POST",
            url: '/Feedback/Create',
            dataType: 'json',
            data: { Author: 'David', Message: m, URL: location.href },
            success: function (msg) {
                console.log(msg); $('#popup').fadeOut(200); clearMessage();
                $('#guava .item').hide();
                loadCounts();
            }
        });
    });
});

function guavaInit() {
    loadMarkup();
        loadCounts();
        clearMessage();
    }

    function loadMarkup() {
        $('body').append(guavaMarkup);
    }

    function clearMessage() {
        $('#guava_content').val("");
    }

    function loadCounts(){
        var url = "http://localhost:58565/API/Feedback/Count?url=" + location.href;
        $.ajax({
            type: "GET",
            url: url,
            dataType: 'json',
            success: function (msg) {
                console.log(msg); $('#guava_count').html(msg);
                $('#guava .item').delay(500).fadeIn();
            }
        });
    }
    var guavaMarkup = '<link href="/Content/guava.css" rel="stylesheet" type="text/css" /><div id="guava"><div id="sidebar"><div id="appTitle">Send Feedback</div><div class="item"><span id="guava_count" class="count">?</span><span class="label">New Items</span></div></div><div id="popup" style="display: none;"> Post a comment or question    <br /><textarea id="guava_content" rows="4" cols="5">YOU SHOULD NEVER SEE THIS!!!</textarea><div style="text-align: right;"><input type="button" value="Cancel" id="guava_cancel"/><input type="button" class="action" value="Post" id="guava_post" /></div><div id="triangle"></div></div></div>';