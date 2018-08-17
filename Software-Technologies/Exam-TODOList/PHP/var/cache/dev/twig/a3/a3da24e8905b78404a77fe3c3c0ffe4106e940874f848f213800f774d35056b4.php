<?php

/* base.html.twig */
class __TwigTemplate_93e2499d03c6402ea1e3906495568257ed0120721f7f5badb0e11600e82927c5 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        $this->parent = false;

        $this->blocks = array(
            'title' => array($this, 'block_title'),
            'stylesheets' => array($this, 'block_stylesheets'),
            'body_id' => array($this, 'block_body_id'),
            'body' => array($this, 'block_body'),
            'main' => array($this, 'block_main'),
        );
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_f78335bc6b1794cd3b694a50c94a92bcc80bcdfd3969672fd1adb7f67e0fa6e0 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_f78335bc6b1794cd3b694a50c94a92bcc80bcdfd3969672fd1adb7f67e0fa6e0->enter($__internal_f78335bc6b1794cd3b694a50c94a92bcc80bcdfd3969672fd1adb7f67e0fa6e0_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "base.html.twig"));

        $__internal_6592d609deeb5ddeab17bc55dbbde89cb651d84fa0bd7034d3f9396c85c83482 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_6592d609deeb5ddeab17bc55dbbde89cb651d84fa0bd7034d3f9396c85c83482->enter($__internal_6592d609deeb5ddeab17bc55dbbde89cb651d84fa0bd7034d3f9396c85c83482_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "base.html.twig"));

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
        // line 19
        echo "    <link rel=\"icon\" type=\"image/x-icon\" href=\"";
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("favicon.ico"), "html", null, true);
        echo "\"/>
</head>

<body id=\"";
        // line 22
        $this->displayBlock('body_id', $context, $blocks);
        echo "\">
";
        // line 23
        $this->displayBlock('body', $context, $blocks);
        // line 26
        echo "</body>
</html>
";
        
        $__internal_f78335bc6b1794cd3b694a50c94a92bcc80bcdfd3969672fd1adb7f67e0fa6e0->leave($__internal_f78335bc6b1794cd3b694a50c94a92bcc80bcdfd3969672fd1adb7f67e0fa6e0_prof);

        
        $__internal_6592d609deeb5ddeab17bc55dbbde89cb651d84fa0bd7034d3f9396c85c83482->leave($__internal_6592d609deeb5ddeab17bc55dbbde89cb651d84fa0bd7034d3f9396c85c83482_prof);

    }

    // line 11
    public function block_title($context, array $blocks = array())
    {
        $__internal_718796834f45e30b79fd12d26016c1a891ecedbe2a96c664cfe974074b76ccdb = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_718796834f45e30b79fd12d26016c1a891ecedbe2a96c664cfe974074b76ccdb->enter($__internal_718796834f45e30b79fd12d26016c1a891ecedbe2a96c664cfe974074b76ccdb_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "title"));

        $__internal_9c3c175b95f92d73bfc83188d9f73ca14e079cf3d8cb50d9be32142bb008de5c = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_9c3c175b95f92d73bfc83188d9f73ca14e079cf3d8cb50d9be32142bb008de5c->enter($__internal_9c3c175b95f92d73bfc83188d9f73ca14e079cf3d8cb50d9be32142bb008de5c_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "title"));

        echo "TODO List";
        
        $__internal_9c3c175b95f92d73bfc83188d9f73ca14e079cf3d8cb50d9be32142bb008de5c->leave($__internal_9c3c175b95f92d73bfc83188d9f73ca14e079cf3d8cb50d9be32142bb008de5c_prof);

        
        $__internal_718796834f45e30b79fd12d26016c1a891ecedbe2a96c664cfe974074b76ccdb->leave($__internal_718796834f45e30b79fd12d26016c1a891ecedbe2a96c664cfe974074b76ccdb_prof);

    }

    // line 12
    public function block_stylesheets($context, array $blocks = array())
    {
        $__internal_c7cce735bc7e79885ec6f90c3e4711b7184e250daa2489affe9f6ae572361e1b = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_c7cce735bc7e79885ec6f90c3e4711b7184e250daa2489affe9f6ae572361e1b->enter($__internal_c7cce735bc7e79885ec6f90c3e4711b7184e250daa2489affe9f6ae572361e1b_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "stylesheets"));

        $__internal_bb79b35ccdb4e8e70e78eeedad394f1b2b207c1def72c26ee80943111bdaa28a = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_bb79b35ccdb4e8e70e78eeedad394f1b2b207c1def72c26ee80943111bdaa28a->enter($__internal_bb79b35ccdb4e8e70e78eeedad394f1b2b207c1def72c26ee80943111bdaa28a_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "stylesheets"));

        // line 13
        echo "        ";
        // line 14
        echo "        ";
        // line 15
        echo "        <link rel=\"stylesheet\" href=\"";
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("css/index-style.css"), "html", null, true);
        echo "\">
        <link rel=\"stylesheet\" href=\"";
        // line 16
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("css/create-style.css"), "html", null, true);
        echo "\">
        <link rel=\"stylesheet\" href=\"";
        // line 17
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("css/delete-style.css"), "html", null, true);
        echo "\">
    ";
        
        $__internal_bb79b35ccdb4e8e70e78eeedad394f1b2b207c1def72c26ee80943111bdaa28a->leave($__internal_bb79b35ccdb4e8e70e78eeedad394f1b2b207c1def72c26ee80943111bdaa28a_prof);

        
        $__internal_c7cce735bc7e79885ec6f90c3e4711b7184e250daa2489affe9f6ae572361e1b->leave($__internal_c7cce735bc7e79885ec6f90c3e4711b7184e250daa2489affe9f6ae572361e1b_prof);

    }

    // line 22
    public function block_body_id($context, array $blocks = array())
    {
        $__internal_83001fec099bb83ab3a1c3dd12f39bb18a38e603228006be488960b5e3dd4f21 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_83001fec099bb83ab3a1c3dd12f39bb18a38e603228006be488960b5e3dd4f21->enter($__internal_83001fec099bb83ab3a1c3dd12f39bb18a38e603228006be488960b5e3dd4f21_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body_id"));

        $__internal_522ffb9d4daea55a0787bd65779de659ee831977e935a24f504a4b42e960f145 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_522ffb9d4daea55a0787bd65779de659ee831977e935a24f504a4b42e960f145->enter($__internal_522ffb9d4daea55a0787bd65779de659ee831977e935a24f504a4b42e960f145_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body_id"));

        
        $__internal_522ffb9d4daea55a0787bd65779de659ee831977e935a24f504a4b42e960f145->leave($__internal_522ffb9d4daea55a0787bd65779de659ee831977e935a24f504a4b42e960f145_prof);

        
        $__internal_83001fec099bb83ab3a1c3dd12f39bb18a38e603228006be488960b5e3dd4f21->leave($__internal_83001fec099bb83ab3a1c3dd12f39bb18a38e603228006be488960b5e3dd4f21_prof);

    }

    // line 23
    public function block_body($context, array $blocks = array())
    {
        $__internal_55e2806ec869745b575b331878a46aaf7ed15d945d95713d9d1396a614d9910e = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_55e2806ec869745b575b331878a46aaf7ed15d945d95713d9d1396a614d9910e->enter($__internal_55e2806ec869745b575b331878a46aaf7ed15d945d95713d9d1396a614d9910e_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body"));

        $__internal_35b649c0b634a83959b3bfc88a4f2e8bd2921a326eefbb336c75e5930ccbc10b = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_35b649c0b634a83959b3bfc88a4f2e8bd2921a326eefbb336c75e5930ccbc10b->enter($__internal_35b649c0b634a83959b3bfc88a4f2e8bd2921a326eefbb336c75e5930ccbc10b_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body"));

        // line 24
        echo "    ";
        $this->displayBlock('main', $context, $blocks);
        
        $__internal_35b649c0b634a83959b3bfc88a4f2e8bd2921a326eefbb336c75e5930ccbc10b->leave($__internal_35b649c0b634a83959b3bfc88a4f2e8bd2921a326eefbb336c75e5930ccbc10b_prof);

        
        $__internal_55e2806ec869745b575b331878a46aaf7ed15d945d95713d9d1396a614d9910e->leave($__internal_55e2806ec869745b575b331878a46aaf7ed15d945d95713d9d1396a614d9910e_prof);

    }

    public function block_main($context, array $blocks = array())
    {
        $__internal_cd846d7b6026ec854a5a8e0cd931da168c434af39bffd7ef77c1c817c24ace0a = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_cd846d7b6026ec854a5a8e0cd931da168c434af39bffd7ef77c1c817c24ace0a->enter($__internal_cd846d7b6026ec854a5a8e0cd931da168c434af39bffd7ef77c1c817c24ace0a_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        $__internal_9bf3ca04964f05f51f016f81f9556efee5f02bcc4deeeeae855c24f26e2c2910 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_9bf3ca04964f05f51f016f81f9556efee5f02bcc4deeeeae855c24f26e2c2910->enter($__internal_9bf3ca04964f05f51f016f81f9556efee5f02bcc4deeeeae855c24f26e2c2910_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        
        $__internal_9bf3ca04964f05f51f016f81f9556efee5f02bcc4deeeeae855c24f26e2c2910->leave($__internal_9bf3ca04964f05f51f016f81f9556efee5f02bcc4deeeeae855c24f26e2c2910_prof);

        
        $__internal_cd846d7b6026ec854a5a8e0cd931da168c434af39bffd7ef77c1c817c24ace0a->leave($__internal_cd846d7b6026ec854a5a8e0cd931da168c434af39bffd7ef77c1c817c24ace0a_prof);

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
        return array (  146 => 24,  137 => 23,  120 => 22,  108 => 17,  104 => 16,  99 => 15,  97 => 14,  95 => 13,  86 => 12,  68 => 11,  56 => 26,  54 => 23,  50 => 22,  43 => 19,  41 => 12,  37 => 11,  30 => 6,);
    }

    /** @deprecated since 1.27 (to be removed in 2.0). Use getSourceContext() instead */
    public function getSource()
    {
        @trigger_error('The '.__METHOD__.' method is deprecated since version 1.27 and will be removed in 2.0. Use getSourceContext() instead.', E_USER_DEPRECATED);

        return $this->getSourceContext()->getCode();
    }

    public function getSourceContext()
    {
        return new Twig_Source("{#
   This is the base template used as the application layout which contains the
   common elements and decorates all the other templates.
   See http://symfony.com/doc/current/book/templating.html#template-inheritance-and-layouts
#}
<!DOCTYPE html>
<html lang=\"en-US\">
<head>
    <meta charset=\"UTF-8\"/>
    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\"/>
    <title>{% block title %}TODO List{% endblock %}</title>
    {% block stylesheets %}
        {#<link rel=\"stylesheet\" href=\"{{ asset('css/reset-style.css') }}\">;#}
        {#<link rel=\"stylesheet\" href=\"https://maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css\">#}
        <link rel=\"stylesheet\" href=\"{{ asset('css/index-style.css') }}\">
        <link rel=\"stylesheet\" href=\"{{ asset('css/create-style.css') }}\">
        <link rel=\"stylesheet\" href=\"{{ asset('css/delete-style.css') }}\">
    {% endblock %}
    <link rel=\"icon\" type=\"image/x-icon\" href=\"{{ asset('favicon.ico') }}\"/>
</head>

<body id=\"{% block body_id %}{% endblock %}\">
{% block body %}
    {% block main %}{% endblock %}
{% endblock %}
</body>
</html>
", "base.html.twig", "D:\\PROJECTS\\Software Technologies\\17. ExamPreparationI\\PHP Skeleton\\app\\Resources\\views\\base.html.twig");
    }
}
