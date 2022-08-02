# Notas

## Como criar um ambiente virtual

~~~cmd
python -m venv env
~~~

## Ativar o ambiente virtual

~~~cmd
env/Scripts/activate
~~~

## Desativar o ambiente virtual:

~~~cmd
deactivate
~~~

## Instalar um pacote

~~~cmd
pip install python-dateutil
~~~

## Ver pacotes instalados no ambiente virtual

~~~cmd
pip freeze
~~~

## Criar arquivo de pacotes necessários

~~~cmd
pip freeze > requirements.txt
~~~

## Instalar pacotes necessários direto do arquivo

~~~cmd
pip install -r requirements.txt
~~~

## Desinstalar pacotes necessários direto do arquivo

~~~cmd
pip freeze > requirements.txt
pip uninstall -r requirements.txt -y
~~~