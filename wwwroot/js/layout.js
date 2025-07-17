window.addEventListener("DOMContentLoaded", () => {
    const page = document.getElementById("pageContent");
        if (page) {
            requestAnimationFrame(() => {
                page.classList.remove("opacity-0");
                page.classList.add("opacity-100");
            });
        }
    });
