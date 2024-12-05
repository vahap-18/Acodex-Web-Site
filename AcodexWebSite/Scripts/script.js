// Tema düğmesini ve tema link'ini seçin
const themeToggleButton = document.getElementById("themeToggleButton");
const themeStylesheet = document.getElementById("themeStylesheet");

// Kullanıcı tercihini localStorage'dan kontrol edin
const currentTheme = localStorage.getItem("theme");

if (currentTheme === "dark") {
    themeStylesheet.href = "https://stackpath.bootstrapcdn.com/bootstrap/5.3.0/css/bootstrap-dark.min.css";
    themeToggleButton.textContent = "Açık Mod";
} else {
    themeStylesheet.href = "https://stackpath.bootstrapcdn.com/bootstrap/5.3.0/css/bootstrap.min.css";
    themeToggleButton.textContent = "Koyu Mod";
}

// Tema düğmesine tıklanınca temayı değiştir
themeToggleButton.addEventListener("click", () => {
    if (themeStylesheet.href.includes("bootstrap.min.css")) {
        // Koyu moda geçiş
        themeStylesheet.href = "https://stackpath.bootstrapcdn.com/bootstrap/5.3.0/css/bootstrap-dark.min.css";
        themeToggleButton.textContent = "Açık Mod";
        localStorage.setItem("theme", "dark");
    } else {
        // Açık moda geçiş
        themeStylesheet.href = "https://stackpath.bootstrapcdn.com/bootstrap/5.3.0/css/bootstrap.min.css";
        themeToggleButton.textContent = "Koyu Mod";
        localStorage.setItem("theme", "light");
    }
});
