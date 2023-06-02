function calculateCost() {
    var areaInput = document.getElementById("area");
    var area = areaInput.value;

    if (area === "") {
        alert("Пожалуйста, введите площадь.");
        return;
    }

    var cost = area * 20;
    var resultElement = document.getElementById("calculator-result");
    resultElement.textContent = cost + " UAH";
}
