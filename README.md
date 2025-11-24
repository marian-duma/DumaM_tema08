# DumaM_tema08
**Fisierele text: quadsVertexList.txt, trianglesVertexList.txt si vertexList.txt se afla in root-ul proiectului, deoarece directorul bin a fost adaugat automat in .gitignore in momentul crearii repo-ului in Visual Studio**

1. Descrieți diferențele dintre iluminarea așa cum funcționează în lumea reală și modelul de iluminare utilizat de OpenGL.
   - In lumea reala iluminarea este globala si este dependenta de traseele razelor de lumina.
   - In OpenGL iluminarea este locala, bazata pe modelul Phong, avand componentele ambiental, difuz si specular.
2. Câte surse de lumină sunt suportate în implementarea curentă a OpenGL cu ajutorul framework-ului OpenTK?
   - 8 surse.
3. Definiți iluminarea de material și specificați unde și când este utilizată aceasta.
   - Iluminarea de material este un set de proprietati care determina efectul luminii asupra unui material.
   - Este utilizata pentru fiecare obiect randat pe ecran
4. Care este efectul asupra diverselor obiecte la activarea unei surse de lumină secundare (per pct. 3), comparativ cu utilizarea unei singure surse de lumină?
   - Fiecare sursa de lumina isi adauga propriul efect, iar obiectul apare iluminat de ambele simultan.
