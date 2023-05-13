var $window = $(window);
$window.scroll(function () {
    if ($(window).width() >= 895) {
        if ($window.scrollTop() >= 330) {
            $('.app').addClass('fixed-header');
        }
        else {
            $('.app').removeClass('fixed-header');
        }
    }
});