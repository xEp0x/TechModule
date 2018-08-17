<?php

/* base.html.twig */
class __TwigTemplate_be3edea7976553d2cc56da9053b49732a5aa0bd4231e60aa95d64997c0ed3459 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        $this->parent = false;

        $this->blocks = array(
            'title' => array($this, 'block_title'),
            'stylesheets' => array($this, 'block_stylesheets'),
            'body_id' => array($this, 'block_body_id'),
            'header' => array($this, 'block_header'),
            'body' => array($this, 'block_body'),
            'main' => array($this, 'block_main'),
            'javascripts' => array($this, 'block_javascripts'),
        );
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_78dacf6a2d086cc9354abd9e0e20a7b345afeceef08e77754657bd6952cd3e92 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_78dacf6a2d086cc9354abd9e0e20a7b345afeceef08e77754657bd6952cd3e92->enter($__internal_78dacf6a2d086cc9354abd9e0e20a7b345afeceef08e77754657bd6952cd3e92_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "base.html.twig"));

        // line 6
        echo "<!DOCTYPE html>
<html lang=\"en-US\">
<head>
    <meta charset=\"UTF-8\"/>
    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\"/>
    <title>";
        // line 11
        $this->displayBlock('title', $context, $blocks);
        echo "</title>
    ";
        // line 12
        $this->displayBlock('stylesheets', $context, $blocks);
        // line 16
        echo "    <link rel=\"icon\" type=\"image/x-icon\" href=\"";
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("favicon.ico"), "html", null, true);
        echo "\"/>
</head>

<body id=\"";
        // line 19
        $this->displayBlock('body_id', $context, $blocks);
        echo "\">

";
        // line 21
        $this->displayBlock('header', $context, $blocks);
        // line 39
        echo "
<div class=\"container body-container\">
    ";
        // line 41
        $this->displayBlock('body', $context, $blocks);
        // line 48
        echo "</div>


";
        // line 51
        $this->displayBlock('javascripts', $context, $blocks);
        // line 57
        echo "
</body>
</html>
";
        
        $__internal_78dacf6a2d086cc9354abd9e0e20a7b345afeceef08e77754657bd6952cd3e92->leave($__internal_78dacf6a2d086cc9354abd9e0e20a7b345afeceef08e77754657bd6952cd3e92_prof);

    }

    // line 11
    public function block_title($context, array $blocks = array())
    {
        $__internal_631c9a56332f9210262a3d5b1c49578b0694a0871e4201173871551e2ece5b45 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_631c9a56332f9210262a3d5b1c49578b0694a0871e4201173871551e2ece5b45->enter($__internal_631c9a56332f9210262a3d5b1c49578b0694a0871e4201173871551e2ece5b45_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "title"));

        echo "Calculator";
        
        $__internal_631c9a56332f9210262a3d5b1c49578b0694a0871e4201173871551e2ece5b45->leave($__internal_631c9a56332f9210262a3d5b1c49578b0694a0871e4201173871551e2ece5b45_prof);

    }

    // line 12
    public function block_stylesheets($context, array $blocks = array())
    {
        $__internal_b76834f9ed4725a5c0e212ca3fae347e7254164a4442184a85ba91f8e4951b7d = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_b76834f9ed4725a5c0e212ca3fae347e7254164a4442184a85ba91f8e4951b7d->enter($__internal_b76834f9ed4725a5c0e212ca3fae347e7254164a4442184a85ba91f8e4951b7d_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "stylesheets"));

        // line 13
        echo "        <link rel=\"stylesheet\" href=\"";
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("css/style.css"), "html", null, true);
        echo "\">
        <link rel=\"stylesheet\" href=\"";
        // line 14
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("css/bootstrap-datetimepicker.min.css"), "html", null, true);
        echo "\">
    ";
        
        $__internal_b76834f9ed4725a5c0e212ca3fae347e7254164a4442184a85ba91f8e4951b7d->leave($__internal_b76834f9ed4725a5c0e212ca3fae347e7254164a4442184a85ba91f8e4951b7d_prof);

    }

    // line 19
    public function block_body_id($context, array $blocks = array())
    {
        $__internal_7f511e9eda0e41e052466618a1e0d123c6d37431f1a2881b64f3702e8847822a = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_7f511e9eda0e41e052466618a1e0d123c6d37431f1a2881b64f3702e8847822a->enter($__internal_7f511e9eda0e41e052466618a1e0d123c6d37431f1a2881b64f3702e8847822a_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body_id"));

        
        $__internal_7f511e9eda0e41e052466618a1e0d123c6d37431f1a2881b64f3702e8847822a->leave($__internal_7f511e9eda0e41e052466618a1e0d123c6d37431f1a2881b64f3702e8847822a_prof);

    }

    // line 21
    public function block_header($context, array $blocks = array())
    {
        $__internal_4cb8ae3160f56a1168e22a07d48b1a87988b6e80ee63fe1ea4d1e3bc1ddabe48 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_4cb8ae3160f56a1168e22a07d48b1a87988b6e80ee63fe1ea4d1e3bc1ddabe48->enter($__internal_4cb8ae3160f56a1168e22a07d48b1a87988b6e80ee63fe1ea4d1e3bc1ddabe48_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "header"));

        // line 22
        echo "    <header>
        <div class=\"navbar navbar-default navbar-static-top\" role=\"navigation\">
            <div class=\"container\">
                <div class=\"navbar-header\">
                    <a href=\"";
        // line 26
        echo $this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("index");
        echo "\" class=\"navbar-brand\">CALCULATOR</a>

                    <button type=\"button\" class=\"navbar-toggle\" data-toggle=\"collapse\" data-target=\".navbar-collapse\">
                        <span class=\"icon-bar\"></span>
                        <span class=\"icon-bar\"></span>
                        <span class=\"icon-bar\"></span>
                    </button>
                </div>

            </div>
        </div>
    </header>
";
        
        $__internal_4cb8ae3160f56a1168e22a07d48b1a87988b6e80ee63fe1ea4d1e3bc1ddabe48->leave($__internal_4cb8ae3160f56a1168e22a07d48b1a87988b6e80ee63fe1ea4d1e3bc1ddabe48_prof);

    }

    // line 41
    public function block_body($context, array $blocks = array())
    {
        $__internal_af4e52641eaf1c8676fb95f75506322edc83856c6bdbe4d13833464374fcf9fc = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_af4e52641eaf1c8676fb95f75506322edc83856c6bdbe4d13833464374fcf9fc->enter($__internal_af4e52641eaf1c8676fb95f75506322edc83856c6bdbe4d13833464374fcf9fc_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body"));

        // line 42
        echo "        <div class=\"row\">
            <div id=\"main\" class=\"col-sm-9\">
                ";
        // line 44
        $this->displayBlock('main', $context, $blocks);
        // line 45
        echo "            </div>
        </div>
    ";
        
        $__internal_af4e52641eaf1c8676fb95f75506322edc83856c6bdbe4d13833464374fcf9fc->leave($__internal_af4e52641eaf1c8676fb95f75506322edc83856c6bdbe4d13833464374fcf9fc_prof);

    }

    // line 44
    public function block_main($context, array $blocks = array())
    {
        $__internal_bcae7d64f5c5b042b796092ab4b143d73e5a83cbb7ffe0e9c780530d0a1f7f76 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_bcae7d64f5c5b042b796092ab4b143d73e5a83cbb7ffe0e9c780530d0a1f7f76->enter($__internal_bcae7d64f5c5b042b796092ab4b143d73e5a83cbb7ffe0e9c780530d0a1f7f76_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        
        $__internal_bcae7d64f5c5b042b796092ab4b143d73e5a83cbb7ffe0e9c780530d0a1f7f76->leave($__internal_bcae7d64f5c5b042b796092ab4b143d73e5a83cbb7ffe0e9c780530d0a1f7f76_prof);

    }

    // line 51
    public function block_javascripts($context, array $blocks = array())
    {
        $__internal_6246f16693b44a0a2d61063277750904188dd540601cbbd338d0ffc35769a7f3 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_6246f16693b44a0a2d61063277750904188dd540601cbbd338d0ffc35769a7f3->enter($__internal_6246f16693b44a0a2d61063277750904188dd540601cbbd338d0ffc35769a7f3_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "javascripts"));

        // line 52
        echo "    <script src=\"";
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("js/jquery-2.2.4.min.js"), "html", null, true);
        echo "\"></script>
    <script src=\"";
        // line 53
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("js/moment.min.js"), "html", null, true);
        echo "\"></script>
    <script src=\"";
        // line 54
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("js/bootstrap.js"), "html", null, true);
        echo "\"></script>
    <script src=\"";
        // line 55
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("js/bootstrap-datetimepicker.min.js"), "html", null, true);
        echo "\"></script>
";
        
        $__internal_6246f16693b44a0a2d61063277750904188dd540601cbbd338d0ffc35769a7f3->leave($__internal_6246f16693b44a0a2d61063277750904188dd540601cbbd338d0ffc35769a7f3_prof);

    }

    public function getTemplateName()
    {
        return "base.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  205 => 55,  201 => 54,  197 => 53,  192 => 52,  186 => 51,  175 => 44,  166 => 45,  164 => 44,  160 => 42,  154 => 41,  134 => 26,  128 => 22,  122 => 21,  111 => 19,  102 => 14,  97 => 13,  91 => 12,  79 => 11,  69 => 57,  67 => 51,  62 => 48,  60 => 41,  56 => 39,  54 => 21,  49 => 19,  42 => 16,  40 => 12,  36 => 11,  29 => 6,);
    }

    public function getSource()
    {
        return "{#
   This is the base template used as the application layout which contains the
   common elements and decorates all the other templates.
   See http://symfony.com/doc/current/book/templating.html#template-inheritance-and-layouts
#}
<!DOCTYPE html>
<html lang=\"en-US\">
<head>
    <meta charset=\"UTF-8\"/>
    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\"/>
    <title>{% block title %}Calculator{% endblock %}</title>
    {% block stylesheets %}
        <link rel=\"stylesheet\" href=\"{{ asset('css/style.css') }}\">
        <link rel=\"stylesheet\" href=\"{{ asset('css/bootstrap-datetimepicker.min.css') }}\">
    {% endblock %}
    <link rel=\"icon\" type=\"image/x-icon\" href=\"{{ asset('favicon.ico') }}\"/>
</head>

<body id=\"{% block body_id %}{% endblock %}\">

{% block header %}
    <header>
        <div class=\"navbar navbar-default navbar-static-top\" role=\"navigation\">
            <div class=\"container\">
                <div class=\"navbar-header\">
                    <a href=\"{{ path('index') }}\" class=\"navbar-brand\">CALCULATOR</a>

                    <button type=\"button\" class=\"navbar-toggle\" data-toggle=\"collapse\" data-target=\".navbar-collapse\">
                        <span class=\"icon-bar\"></span>
                        <span class=\"icon-bar\"></span>
                        <span class=\"icon-bar\"></span>
                    </button>
                </div>

            </div>
        </div>
    </header>
{% endblock %}

<div class=\"container body-container\">
    {% block body %}
        <div class=\"row\">
            <div id=\"main\" class=\"col-sm-9\">
                {% block main %}{% endblock %}
            </div>
        </div>
    {% endblock %}
</div>


{% block javascripts %}
    <script src=\"{{ asset('js/jquery-2.2.4.min.js') }}\"></script>
    <script src=\"{{ asset('js/moment.min.js') }}\"></script>
    <script src=\"{{ asset('js/bootstrap.js') }}\"></script>
    <script src=\"{{ asset('js/bootstrap-datetimepicker.min.js') }}\"></script>
{% endblock %}

</body>
</html>
";
    }
}
