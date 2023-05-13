var $window = $(window);
$window.scroll(function () {
    if ($(window).width() >= 768) {
        if ($window.scrollTop() >= 170) {
            $('.app').addClass('fixed-header');
        }
        else {
            $('.app').removeClass('fixed-header');
        }
    }
});