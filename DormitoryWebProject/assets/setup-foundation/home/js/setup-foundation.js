
$(function () {
    //Phóng to Avatar khi Sidebar Expanded
    $(document).on('shown.lte.pushmenu', function () {
        $('#user-img').addClass('user-img-scale');
        $('.info').show();
    });

    //Thu nhỏ Avatar khi Sidebar Collapsed
    $(document).on('collapsed.lte.pushmenu', function () {
        $('#user-img').removeClass('user-img-scale');
        $('.info').hide();
    });

    //Hiệu ứng phóng to, thu nhỏ Avatar khi Sidebar xảy ra hover
    $('.main-sidebar').hover(
        function () {
            if (window.matchMedia('(min-width: 1024px)').matches && $('body').hasClass('sidebar-collapse')) {
                $('#user-img').addClass('user-img-scale');
                $('.info').show();
            }
        },
        function () {
            if (window.matchMedia('(min-width: 1024px)').matches && $('body').hasClass('sidebar-collapse')) {
                $('#user-img').removeClass('user-img-scale');
                $('.info').hide();
            }
        });
    //Hiệu ứng phóng to, thu nhỏ Avatar khi Sidebar xảy ra Focus
    $('.main-sidebar').focusin(function () {
        $('#user-img').addClass('user-img-scale-focus');
    });
    $('.main-sidebar').focusout(function () {
        $('#user-img').removeClass('user-img-scale-focus');
    });
});
