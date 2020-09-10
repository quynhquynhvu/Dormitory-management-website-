$(function () {
    $('.my-nor-nav').append('<div style="clear:both;"></div>');
    // Back to top button
    var btn = $('#back-top-bt');
    $(window).scroll(function () {
        if ($(window).scrollTop() > 300) {
            btn.addClass('show');
        } else {
            btn.removeClass('show');
        }
    });
    btn.on('click', function (e) {
        e.preventDefault();
        $('html, body').animate({ scrollTop: 0 }, '300');
    });
});