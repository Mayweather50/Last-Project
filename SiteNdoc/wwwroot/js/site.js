document.addEventListener("DOMContentLoaded", function () {
    let tabs = document.querySelectorAll('.tab');
    tabs.forEach(tab => {
        tab.addEventListener('click', function (e) {
            e.preventDefault();


            if (/tab.+?/.test(e.target.classList)) {
                console.log(e.target.classList)
                for (let sibling of e.target.closest(".tabs").children) {
                    sibling.classList.remove('tab--active');
                }
                for (let sibling of e.target.closest('.tabs-wrapper').parentNode.children) {
                    if (sibling.classList.contains('tabs-container')) {
                        sibling.querySelectorAll('.tabs-content').forEach(content => {
                            content.classList.remove('tabs-content--active');
                        });
                    }
                }
                e.target.closest(".tab").classList.add('tab--active');
                document.querySelector(e.target.closest(".tab").getAttribute('href')).classList.add('tabs-content--active');
            }
        });
    });
})