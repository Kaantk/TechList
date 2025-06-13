// Form validation ve submit işlemi
document.getElementById('demirbasForm').addEventListener('submit', function (e) {
    e.preventDefault();

    // Temel validation
    const requiredFields = ['demirbasNo', 'demirbasIsmi', 'birim'];
    let isValid = true;

    requiredFields.forEach(field => {
        const element = document.getElementById(field);
        if (!element.value.trim()) {
            element.classList.add('is-invalid');
            isValid = false;
        } else {
            element.classList.remove('is-invalid');
        }
    });

    if (isValid) {
        // Form verilerini toplama
        const formData = new FormData(this);
        const data = Object.fromEntries(formData);
        data.aktifMi = document.getElementById('aktifMi').checked;

        // Başarı mesajı gösterme
        alert('Demirbaş başarıyla kaydedildi!');
        console.log('Form Data:', data);

        // Form reset
        this.reset();
        document.getElementById('aktifMi').checked = true;
    } else {
        alert('Lütfen zorunlu alanları doldurunuz!');
    }
});

// Real-time validation
document.querySelectorAll('input[required], select[required]').forEach(element => {
    element.addEventListener('blur', function () {
        if (this.value.trim()) {
            this.classList.remove('is-invalid');
            this.classList.add('is-valid');
        } else {
            this.classList.remove('is-valid');
            this.classList.add('is-invalid');
        }
    });
});
