// Kity.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include <iostream>
#include <string>
#include <algorithm>

using namespace std;




int binary_search()
{   

    int arr[10]; 
    int key; 
    cout << "Enter 10 elements for array " << endl;

    for (int i = 0; i < 10; i++) {
        cin >> arr[i]; // count elements
    }
    sort(arr, arr + 10); // fast sort
     

    cout << endl << "Enter key: ";

    cin >> key; // count key

    bool flag = false;
    int l = 0; // left border
    int r = 9; // right border
    int mid;

    while ((l <= r) && (flag != true)) {
        mid = (l + r) / 2; 

        if (arr[mid] == key) flag = true; 
        if (arr[mid] > key) r = mid - 1; 
        else l = mid + 1;
    }

    if (flag) cout << "index of element  " << key << " in array equals: " << mid;
    else cout << "Sorry , you key is not exist";

}

int sort_simple()

{

    const int number = 10;



    int simple_array[number];
    
    for (int i = 0; i < number ; i++)
    {
        cin >> simple_array[i]; // fill array
    }
    
     

    cout << simple_array << endl;

     

}

int bouble_search ()
{
    int* arr; // указатель для выделения памяти под массив
    int size; // размер массива

    // Ввод количества элементов массива
    cout << "n = ";
    cin >> size;

    if (size <= 0) {
        // Размер масива должен быть положитлеьным
        cerr << "Invalid size" << endl;
        return 1;
    }

    arr = new int[size]; // выделение памяти под массив

    // заполнение массива
    for (int i = 0; i < size; i++) {
        cout << "arr[" << i << "] = ";
        cin >> arr[i];
    }

    int temp; // временная переменная для обмена элементов местами

    // Сортировка массива пузырьком
    for (int i = 0; i < size - 1; i++) {
        for (int j = 0; j < size - i - 1; j++) {
            if (arr[j] > arr[j + 1]) {
                // меняем элементы местами
                temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
            }
        }
    }

    // Вывод отсортированного массива на экран
    for (int i = 0; i < size; i++) {
        cout << arr[i] << " ";
    }
    cout << endl;

    delete[] arr; // освобождение памяти;

    return 0;
}

int main()
{
    setlocale(LC_ALL, "rus");
    
      
}

// Запуск программы: CTRL+F5 или меню "Отладка" > "Запуск без отладки"
// Отладка программы: F5 или меню "Отладка" > "Запустить отладку"

// Советы по началу работы 
//   1. В окне обозревателя решений можно добавлять файлы и управлять ими.
//   2. В окне Team Explorer можно подключиться к системе управления версиями.
//   3. В окне "Выходные данные" можно просматривать выходные данные сборки и другие сообщения.
//   4. В окне "Список ошибок" можно просматривать ошибки.
//   5. Последовательно выберите пункты меню "Проект" > "Добавить новый элемент", чтобы создать файлы кода, или "Проект" > "Добавить существующий элемент", чтобы добавить в проект существующие файлы кода.
//   6. Чтобы снова открыть этот проект позже, выберите пункты меню "Файл" > "Открыть" > "Проект" и выберите SLN-файл.
