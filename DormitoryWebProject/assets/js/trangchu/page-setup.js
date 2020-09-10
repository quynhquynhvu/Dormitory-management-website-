$(function () {
    // A custom hoverline
    $('.my-nor-nav').hoverline({
        'color': '#222830',
        'height': '4px',
        'speed': '200',
        'start': '1',
    });
    // Touch Benefit Carousel - Swipe left or right to see item
    $(".hidden-benefit-carousel").on("touchstart", function (event) {
        var xClick = event.originalEvent.touches[0].pageX;
        $(this).one("touchmove", function (event) {
            var xMove = event.originalEvent.touches[0].pageX;
            if (Math.floor(xClick - xMove) > 5) {
                $(this).carousel('next');
            }
            else if (Math.floor(xClick - xMove) < -5) {
                $(this).carousel('prev');
            }
        });
        $(".hidden-benefit-carousel").on("touchend", function () {
            $(this).off("touchmove");
        });
    });

    // Touch Testinominal Carousel - Swipe left or right to see item
    $(".testimonial-carousel").on("touchstart", function (event) {
        var xClick = event.originalEvent.touches[0].pageX;
        $(this).one("touchmove", function (event) {
            var xMove = event.originalEvent.touches[0].pageX;
            if (Math.floor(xClick - xMove) > 5) {
                $(this).carousel('next');
            }
            else if (Math.floor(xClick - xMove) < -5) {
                $(this).carousel('prev');
            }
        });
        $(".testimonial-carousel").on("touchend", function () {
            $(this).off("touchmove");
        });
    });

    $('.testimonial-carousel').carousel({ interval: 8000 })

    $('[data-toggle="tooltip"]').tooltip();
});